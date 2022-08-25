using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbearia
{
    internal class BaseRepository<T> : IRepository<T> where T : BaseModel
    {
        List<T> entities;
        public BaseRepository()
        {
            this.entities = new List<T>();
        }
        public string Create(T entity)
        {
            throw new NotImplementedException();
        }

        public string Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> Read()
        {
            throw new NotImplementedException();
        }

        public string Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
