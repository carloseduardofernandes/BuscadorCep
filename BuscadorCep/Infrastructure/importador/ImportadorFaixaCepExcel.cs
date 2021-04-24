using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using BuscadorCep.Domain;

namespace BuscadorCep.Infrastructure
{
    public class ImportadorFaixaCepExcel: IImportadorFaixaCep
    {
        public List<FaixaCep> ImportarDoArquivo(string filePath)
        {            
            if (!File.Exists(filePath))
            {
                throw new Exception("Arquivo de importação não encontrado");
            }

            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    DataSet result = CreateDataSet(reader);

                    return GetTable(result).Rows.Cast<DataRow>()
                        .Select(item => CreateFaixaCep(item))
                        .ToList();
                }
            }            
        }

        private FaixaCep CreateFaixaCep(DataRow item)
        {
            return new FaixaCep
            {
                Faixa   = item[0].ToString(),
                Inicial = item[1].ToString(),
                Final   = item[2].ToString()
            };
        }

        private DataTable GetTable(DataSet result)
        {
            if (result.Tables.Count == 0) 
            {
                throw new IndexOutOfRangeException("Lista de ceps não encontrada");
            }

            return result.Tables[0];
        }

        private DataSet CreateDataSet(IExcelDataReader reader)
        {
            return reader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = true
                }
            });
        }
    }
}
