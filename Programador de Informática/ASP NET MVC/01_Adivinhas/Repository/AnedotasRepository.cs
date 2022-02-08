using _01_Adivinhas.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace _01_Adivinhas.Repository
{
    public class AnedotasRepository
    {
        private List<Anedotas> listAnedotasData;

        public AnedotasRepository()
        {
            listAnedotasData = new List<Anedotas>();

            if (File.Exists("Anedotas.json"))
            {
                listAnedotasData = JsonConvert.DeserializeObject<List<Anedotas>>(File.ReadAllText("Anedotas.json"));
            }
        }

        private void SaveDataBase() 
        {
            File.WriteAllText("Anedotas.json", JsonConvert.SerializeObject(listAnedotasData));
        }

        public List<Anedotas> ListAll() 
        {
            return listAnedotasData;
        }

        public void Add(Anedotas _ane) 
        {
            var id = 0;

            if (listAnedotasData.Any())
            {
                id = listAnedotasData.Max(element => element.id);
            }
            _ane.id++;
            listAnedotasData.Add(_ane);
            SaveDataBase();
        }



    }
}
