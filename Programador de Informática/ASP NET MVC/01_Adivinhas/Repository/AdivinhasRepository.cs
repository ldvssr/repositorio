using _01_Adivinhas.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace _01_Adivinhas.Repository
{
    public class AdivinhasRepository
    {
        private List<Adivinhas> data;

        public AdivinhasRepository()
        {
            data = new List<Adivinhas>();
            if (File.Exists("Adivinhas.json"))
            {
                data = JsonConvert.DeserializeObject<List<Adivinhas>>(File.ReadAllText("Adivinhas.json"));
            }

        }

        private void SaveDataBase()
        {
            File.WriteAllText("Adivinhas.json", JsonConvert.SerializeObject(data));
        }

        public List<Adivinhas> ListAll()
        {
            return data;
        }

        public void Add(Adivinhas item)
        {

            var id = 0;
            if (data.Any())
            {
                id = data.Max(x => x.id);
            }

            item.id = id + 1;

            data.Add(item);
            SaveDataBase();

        }

        public Adivinhas ListById(int id)
        {
            return data.FirstOrDefault(x => x.id == id);
        }
    }

}
