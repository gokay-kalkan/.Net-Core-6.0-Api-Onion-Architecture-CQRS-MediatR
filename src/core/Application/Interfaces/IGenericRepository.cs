using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IGenericRepository<T>
    {
        public List<T> GetAll();
        public T GetOne(int id);

        public Task  Add(T p);
        public Task Update(T p);
        public void Delete(T p);
    }
}
