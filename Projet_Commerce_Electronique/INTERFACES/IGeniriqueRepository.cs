using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique_CF.INTERFACES
{
    public interface IGeniricRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T getByID(int id);
        void deleteByID(T entity);
        void insert(T entity);

        void update(T entity);

    }
}
