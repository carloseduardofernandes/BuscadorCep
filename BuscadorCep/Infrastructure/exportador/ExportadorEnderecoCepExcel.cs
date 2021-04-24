using ClosedXML.Excel;
using System.IO;
using BuscadorCep.Domain;
using System;

namespace BuscadorCep.Infrastructure
{
    public class ExportadorEnderecoCepExcel : IExportadorEnderecoCep
    {
        private const string WORKSHEET = "Lista de CEPs";

        readonly private string outputFile;
        readonly private XLWorkbook workbook;
        readonly private IXLWorksheet worksheet;

        public ExportadorEnderecoCepExcel(string outputFile)
        {
            this.outputFile = outputFile;
            this.workbook   = GetWorkbook();
            this.worksheet  = workbook.Worksheet(WORKSHEET);
        }

        private XLWorkbook GetWorkbook()
        {
            if (!File.Exists(outputFile))
            {
                CreateWorkbook();
            }

            return openWorkbook();
        }

        private XLWorkbook openWorkbook()
        {            
            var workbook = new XLWorkbook(outputFile);
            workbook.Worksheet(WORKSHEET);
            return workbook;            
        }

        private void CreateWorkbook()
        {            
            var _workbook = new XLWorkbook();

            IXLWorksheet _worksheet = _workbook.AddWorksheet(WORKSHEET);

            _worksheet.Cell("A1").Value = "CEP";
            _worksheet.Cell("B1").Value = "BAIRRO";
            _worksheet.Cell("C1").Value = "CIDADE";
            _worksheet.Cell("D1").Value = "COMPLEMENTO";
            _worksheet.Cell("E1").Value = "LOGRADOURO";
            _worksheet.Cell("F1").Value = "UF";
            _worksheet.Cell("G1").Value = "DATA PROCESSAMENTO";
            _worksheet.Cell("H1").Value = "STATUS PROCESSAMENTO";
            _worksheet.Cell("I1").Value = "ERRO PROCESSAMENTO";

            _workbook.SaveAs(outputFile);                        
        }

        public void Exportar(EnderecoCep endereco)
        {            
            if (endereco == null)
            {
                return;
            }

            int lastRow = worksheet.LastRowUsed().RowNumber() + 1;
            var row = lastRow.ToString();
            
            worksheet.Cell($"A{row}").Value = endereco.Cep;
            worksheet.Cell($"B{row}").Value = endereco.Bairro;
            worksheet.Cell($"C{row}").Value = endereco.Cidade;
            worksheet.Cell($"D{row}").Value = endereco.Complemento;
            worksheet.Cell($"E{row}").Value = endereco.Logradouro;
            worksheet.Cell($"F{row}").Value = endereco.Uf;
            worksheet.Cell($"G{row}").Value = endereco.DataProcessamento;
            worksheet.Cell($"H{row}").Value = endereco.StatusProcessamento;
            worksheet.Cell($"I{row}").Value = endereco.ErroProcessamento;

            workbook.Save();

            Console.WriteLine(endereco.DataProcessamento);
        }        
    }
}
