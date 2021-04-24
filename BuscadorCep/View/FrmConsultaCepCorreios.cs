using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using BuscadorCep.Domain;
using BuscadorCep.Infrastructure;

namespace BuscadorCep
{
    public partial class FrmFormMenu : Form, IObservadorStatusImportacao
    {
        private bool leituraIniciada;
        private Thread threadImportadorCeps;
        private string arquivoOrigem;
        private string arquivoDestino;

        public FrmFormMenu()
        {
            InitializeComponent();
        }

        private void btnSelecionarArquivoCep_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogCep.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Erro ao selecionar o arquivo de CEPS, detalhe do erro: {exception.Message}", 
                    "Erro",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private void openFileDialogCep_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var file = openFileDialogCep.FileName;

            if (!string.IsNullOrEmpty(file))
            {
                arquivoOrigem = file;
                lblArquivoSelecionado.Text = Path.GetFileName(file);                
            }
        }

        private void btnSelecionarPastaResultado_Click(object sender, EventArgs e)
        {
            try
            {
                if (folderBrowserDialogDestinoResultado.ShowDialog() == DialogResult.OK)
                {
                    var folder = folderBrowserDialogDestinoResultado.SelectedPath;
                    if (!string.IsNullOrEmpty(folder))
                    {
                        arquivoDestino = folder + @"\Resultado.xlsx";
                        lblCaminhoResultadoSelecionado.Text = arquivoDestino;                        
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Erro ao selecionar a pasta para salvar o resultado, detalhe do erro: {exception.Message}", 
                    "Erro", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (leituraIniciada)
                {
                    MessageBox.Show("A Extração já iniciou, por favor aguarde!",
                        "Atenção",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }                                
                
                if (string.IsNullOrEmpty(arquivoOrigem) || string.IsNullOrEmpty(arquivoDestino))
                {
                    MessageBox.Show("Você deve selecionar um arquivo de ceps e o caminho para salvar o resultado!",
                        "Atenção",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                
                ExportarCeps(arquivoOrigem, arquivoDestino);
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Atenção, ocorreu um erro ao processar os dados!\n {exception.Message}",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ExportarCeps(string arquivoOrigem, string arquivoDestino)
        {
            threadImportadorCeps = new Thread(new ThreadStart(() => ConsultarCeps(arquivoOrigem, arquivoDestino)))
            {
                IsBackground = true
            };
            threadImportadorCeps.Start();
        }

        private void ConsultarCeps(string arquivoOrigem, string arquivoDestino)
        {            
            try
            {
                InvokeIniciarBuscaCeps();

                var buscador = BuscadorEnderecoCepFactory.GetBuscadorEnderecoCepExcel(arquivoDestino);

                buscador.NotificadorStatusImportacao().Registrar(this);
                buscador.ExtrairCepsDosCorreios(arquivoOrigem);                

                InvokeFinalizarBuscaCeps();

                MessageBox.Show("Finalizado!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                InvokeFinalizarBuscaCeps();

                MessageBox.Show($"Atenção, ocorreu um erro ao processar os dados!\n {exception.Message}",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);                
            }                                    
        }

        private void InvokeFinalizarBuscaCeps()
        {
            if (InvokeRequired)
            {
                this?.Invoke(new Action(FinalizarBuscaDeCeps));
            }
        }

        private void InvokeIniciarBuscaCeps()
        {
            if (InvokeRequired)
            {
                this?.Invoke(new Action(IniciarBuscaDeCeps));
            }
        }

        private void IniciarBuscaDeCeps()
        {
            this.leituraIniciada = true;            
            btnSelecionarArquivoCep.Enabled = false;
            btnSelecionarPastaResultado.Enabled = false;
        }
   
        private void FinalizarBuscaDeCeps()
        {
            this.leituraIniciada = false;
            btnSelecionarArquivoCep.Enabled = true;
            btnSelecionarPastaResultado.Enabled = true;
        }

        public void AtualizaStatusImportacao(ImportadorInfo importadorInfo)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<ImportadorInfo>(AtualizaStatusImportacao), new object[] { importadorInfo });
                return;
            }

            lbQuantidadeCEPs.Text = importadorInfo.QuantidadeRegistros.ToString();
            lbQuantidadeImportados.Text = importadorInfo.QuantidadeProcessados.ToString();
        }

        private void FrmFormMenu_Load(object sender, EventArgs e)
        {
            arquivoOrigem = @"..\..\Lista_de_CEPs.xlsx";
            arquivoDestino = @"..\..\Resultado.xlsx";

            lblArquivoSelecionado.Text = arquivoOrigem;
            lblCaminhoResultadoSelecionado.Text = arquivoDestino;
            
            folderBrowserDialogDestinoResultado.SelectedPath = Path.GetDirectoryName(Application.ExecutablePath);
        }

        private void FrmFormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            threadImportadorCeps?.Interrupt();            
        }        
    }
}
