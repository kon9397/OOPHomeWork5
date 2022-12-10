using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Dictionary
    {
        private string[] key = new string[5];
        private string[] ENG = new string[5];
        private string[] UA = new string[5];

        public Dictionary()
        {
            key[0] = "книга"; UA[0] = "книга"; ENG[0] = "book";
            key[1] = "карандаш"; UA[1] = "олівець"; ENG[1] = "pencil";
            key[2] = "программирование"; UA[2] = "програмування"; ENG[2] = "programming";
            key[3] = "цветок"; UA[3] = "квітка"; ENG[3] = "flower";
            key[4] = "парикмахерская"; UA[4] = "перукарня"; ENG[4] = "hairdresser";
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                {
                    return key[index] + " - " + UA[index] + " - " + ENG[index];
                }
                return "Попытка обращения за пределы массива.";
            }
        }
        public string this[string index]
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                {
                    if(key[i] == index)
                    {
                        return key[i] + " - " + UA[i] + " - " + ENG[i];
                    }
                    if(UA[i] == index)
                    {
                        return UA[i] + " - " + key[i] + " - " + ENG[i];
                    }
                    if(ENG[i] == index)
                    {
                        return ENG[i] + " - " + key[i] + " - " + UA[i];
                    }
                }
                return $"{index} - нет перевода";
            }
        }
    }
}
