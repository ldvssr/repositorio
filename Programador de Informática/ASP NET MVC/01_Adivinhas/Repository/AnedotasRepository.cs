using _01_Adivinhas.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _01_Adivinhas.Repository
{
    public class AnedotasRepository
    {
        private List<Anedotas> data;

        public AnedotasRepository()
        {
            data = new List<Anedotas>();
            if (File.Exists("Anedotas.json"))
            {
                data = JsonConvert.DeserializeObject<List<Anedotas>>(File.ReadAllText("Anedotas.json"));
            }

        }

        private void SaveDataBase()
        {
            File.WriteAllText("Anedotas.json", JsonConvert.SerializeObject(data));
        }

        public List<Anedotas> ListAll()
        {
            return data;
        }

        public void Add(Anedotas item)
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

        internal void Add(object anedota)
        {
            throw new System.NotImplementedException();
        }

        public Anedotas ListById(int id)
        {
            return data.FirstOrDefault(x => x.id == id);
        }
    }
}
