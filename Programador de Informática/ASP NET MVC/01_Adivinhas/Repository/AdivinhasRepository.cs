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

        public void Add(Adivinhas _adv)
        {
            var id = 0;
            //verifica se ja existe alguma info na BD (ficheiro JSON)
            if (data.Any())
            {
                id = data.Max(value => value.id);
            }
            //incrementa o id
            _adv.id = id++;

            data.Add(_adv);
            //gravar no ficheiro JSON
            SaveDataBase();
        }


        public Adivinhas ListById(int _id)
        {
            return data.FirstOrDefault(value => value.id == _id);
        }

        public void Update(Adivinhas item)
        {
            var dbItem = data.FirstOrDefault(x => x.id == item.id);
            if (dbItem == null)
                throw new KeyNotFoundException(item.id.ToString());
            dbItem.pergunta = item.pergunta;
            dbItem.resposta = item.resposta;
            SaveDataBase();
        }
    }
}
