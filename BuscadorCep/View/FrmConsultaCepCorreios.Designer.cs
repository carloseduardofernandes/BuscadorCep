
namespace BuscadorCep
{
    partial class FrmFormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConsultar = new System.Windows.Forms.Button();
            this.openFileDialogCep = new System.Windows.Forms.OpenFileDialog();
            this.lblArquivo = new System.Windows.Forms.Label();
            this.btnSelecionarArquivoCep = new System.Windows.Forms.Button();
            this.lblArquivoSelecionado = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.folderBrowserDialogDestinoResultado = new System.Windows.Forms.FolderBrowserDialog();
            this.lblCaminhoResultadoSelecionado = new System.Windows.Forms.Label();
            this.btnSelecionarPastaResultado = new System.Windows.Forms.Button();
            this.lblCaminhoResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbQuantidadeImportados = new System.Windows.Forms.Label();
            this.lbQuantidadeCEPs = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(423, 131);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(133, 27);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "Buscar Dados CEP";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // openFileDialogCep
            // 
            this.openFileDialogCep.Title = "Selecione o arquivo de CEPS";
            this.openFileDialogCep.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogCep_FileOk);
            // 
            // lblArquivo
            // 
            this.lblArquivo.AutoSize = true;
            this.lblArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArquivo.Location = new System.Drawing.Point(14, 51);
            this.lblArquivo.Name = "lblArquivo";
            this.lblArquivo.Size = new System.Drawing.Size(149, 15);
            this.lblArquivo.TabIndex = 1;
            this.lblArquivo.Text = "Arquivo ceps selecionado:";
            // 
            // btnSelecionarArquivoCep
            // 
            this.btnSelecionarArquivoCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarArquivoCep.Location = new System.Drawing.Point(468, 46);
            this.btnSelecionarArquivoCep.Name = "btnSelecionarArquivoCep";
            this.btnSelecionarArquivoCep.Size = new System.Drawing.Size(88, 23);
            this.btnSelecionarArquivoCep.TabIndex = 2;
            this.btnSelecionarArquivoCep.Text = "Selecionar arquivo de CEPS";
            this.btnSelecionarArquivoCep.UseVisualStyleBackColor = true;
            this.btnSelecionarArquivoCep.Click += new System.EventHandler(this.btnSelecionarArquivoCep_Click);
            // 
            // lblArquivoSelecionado
            // 
            this.lblArquivoSelecionado.AutoSize = true;
            this.lblArquivoSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArquivoSelecionado.Location = new System.Drawing.Point(164, 51);
            this.lblArquivoSelecionado.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblArquivoSelecionado.MinimumSize = new System.Drawing.Size(300, 0);
            this.lblArquivoSelecionado.Name = "lblArquivoSelecionado";
            this.lblArquivoSelecionado.Size = new System.Drawing.Size(300, 15);
            this.lblArquivoSelecionado.TabIndex = 3;
            this.lblArquivoSelecionado.Text = "nenhum";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(122, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(244, 17);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Buscar dados endereço por CEP";
            // 
            // folderBrowserDialogDestinoResultado
            // 
            this.folderBrowserDialogDestinoResultado.Description = "Seleciona a pasta para salvar o resultado.";
            // 
            // lblCaminhoResultadoSelecionado
            // 
            this.lblCaminhoResultadoSelecionado.AutoSize = true;
            this.lblCaminhoResultadoSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaminhoResultadoSelecionado.Location = new System.Drawing.Point(164, 88);
            this.lblCaminhoResultadoSelecionado.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblCaminhoResultadoSelecionado.MinimumSize = new System.Drawing.Size(300, 0);
            this.lblCaminhoResultadoSelecionado.Name = "lblCaminhoResultadoSelecionado";
            this.lblCaminhoResultadoSelecionado.Size = new System.Drawing.Size(300, 15);
            this.lblCaminhoResultadoSelecionado.TabIndex = 7;
            this.lblCaminhoResultadoSelecionado.Text = "nenhum";
            // 
            // btnSelecionarPastaResultado
            // 
            this.btnSelecionarPastaResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarPastaResultado.Location = new System.Drawing.Point(468, 83);
            this.btnSelecionarPastaResultado.Name = "btnSelecionarPastaResultado";
            this.btnSelecionarPastaResultado.Size = new System.Drawing.Size(88, 23);
            this.btnSelecionarPastaResultado.TabIndex = 6;
            this.btnSelecionarPastaResultado.Text = "Selecionar arquivo de CEPS";
            this.btnSelecionarPastaResultado.UseVisualStyleBackColor = true;
            this.btnSelecionarPastaResultado.Click += new System.EventHandler(this.btnSelecionarPastaResultado_Click);
            // 
            // lblCaminhoResultado
            // 
            this.lblCaminhoResultado.AutoSize = true;
            this.lblCaminhoResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaminhoResultado.Location = new System.Drawing.Point(14, 88);
            this.lblCaminhoResultado.Name = "lblCaminhoResultado";
            this.lblCaminhoResultado.Size = new System.Drawing.Size(149, 15);
            this.lblCaminhoResultado.TabIndex = 5;
            this.lblCaminhoResultado.Text = "Caminho salvar resultado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quantidade CEPs Consultados:";
            // 
            // lbQuantidadeImportados
            // 
            this.lbQuantidadeImportados.AutoSize = true;
            this.lbQuantidadeImportados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantidadeImportados.Location = new System.Drawing.Point(198, 140);
            this.lbQuantidadeImportados.Name = "lbQuantidadeImportados";
            this.lbQuantidadeImportados.Size = new System.Drawing.Size(15, 15);
            this.lbQuantidadeImportados.TabIndex = 9;
            this.lbQuantidadeImportados.Text = "0";
            // 
            // lbQuantidadeCEPs
            // 
            this.lbQuantidadeCEPs.AutoSize = true;
            this.lbQuantidadeCEPs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantidadeCEPs.Location = new System.Drawing.Point(198, 119);
            this.lbQuantidadeCEPs.Name = "lbQuantidadeCEPs";
            this.lbQuantidadeCEPs.Size = new System.Drawing.Size(15, 15);
            this.lbQuantidadeCEPs.TabIndex = 11;
            this.lbQuantidadeCEPs.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Quantidade Total de CEPs:";
            // 
            // FrmFormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 170);
            this.Controls.Add(this.lbQuantidadeCEPs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbQuantidadeImportados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCaminhoResultadoSelecionado);
            this.Controls.Add(this.btnSelecionarPastaResultado);
            this.Controls.Add(this.lblCaminhoResultado);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblArquivoSelecionado);
            this.Controls.Add(this.btnSelecionarArquivoCep);
            this.Controls.Add(this.lblArquivo);
            this.Controls.Add(this.btnConsultar);
            this.MaximizeBox = false;
            this.Name = "FrmFormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta CEP correios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmFormMenu_FormClosed);
            this.Load += new System.EventHandler(this.FrmFormMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.OpenFileDialog openFileDialogCep;
        private System.Windows.Forms.Label lblArquivo;
        private System.Windows.Forms.Button btnSelecionarArquivoCep;
        private System.Windows.Forms.Label lblArquivoSelecionado;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogDestinoResultado;
        private System.Windows.Forms.Label lblCaminhoResultadoSelecionado;
        private System.Windows.Forms.Button btnSelecionarPastaResultado;
        private System.Windows.Forms.Label lblCaminhoResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbQuantidadeImportados;
        private System.Windows.Forms.Label lbQuantidadeCEPs;
        private System.Windows.Forms.Label label3;
    }
}

