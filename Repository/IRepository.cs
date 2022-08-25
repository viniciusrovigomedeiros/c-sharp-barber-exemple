using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbearia
{
    internal interface IRepository<T> where T : BaseModel
    {
        string Create(T entity);
        List<T> Read();
        string Update(T entity);
        string Delete(int id);

    }
}
