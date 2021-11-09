using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentFour
{
    class GenericRepository<T> : IRepository<T> 
        where T : Entity
    {
        List<T> data = new List<T>();

        public void Add(T item)
        {
            data.Add(item);
        }

        public IEnumerable<T> GetAll()
        {
            return data;
        }

        public T GetById(int id)
        {
            foreach(T i in data)
            {
                if(i.Id == id)
                {
                    return i;
                }
                
            }
            return null;
            
        }

        public void Remove(T item)
        {
            data.Remove(item);
        }

        public void Save()
        {
            StringBuilder sb = new StringBuilder("Printout for GenericRepository:\n\n\n");

            foreach(T i in data)
            {
                sb.Append(i.ToString() + "\n");
            }

            File.WriteAllTextAsync("RepoOutput.txt", sb.ToString());
        }
    }
}
