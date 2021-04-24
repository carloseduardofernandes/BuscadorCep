using Microsoft.Isam.Esent.Collections.Generic;
using System.Windows.Forms;
using BuscadorCep.Domain;
using System;

namespace BuscadorCep.Infrastructure.cache
{
    public class PersistentCacheCep: ICacheCep
    {
        private PersistentDictionary<int, string> pairs;        

        public void Open()
        {
            string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\cache\db\";
            pairs = new PersistentDictionary<int, string>(path);
        }

        public bool ContainsKey(int cep)
        {
            CheckCacheOpened();
            return pairs.ContainsKey(cep);
        }   

        public void Add(int cep, string statusProcessamento)
        {
            CheckCacheOpened();
            pairs.Add(cep, statusProcessamento);
            pairs.Flush();            
        }

        private void CheckCacheOpened()
        {
            if (pairs == null)
            {
                throw new Exception("Cache não foi iniciado");
            }
        }
    }
}
