using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class GenericRepository<T,TContext> : IGenericRepository<T>where T:class,new() where TContext:Context
    {
        private Context _db;
        DbSet<T> _object;
        public GenericRepository(Context db)
        {
            _db = db;
            _object = db.Set<T>();
        }
        public async Task  Add(T p)
        {
            _object.Add(p);
            _db.SaveChanges();
        }

        public void Delete(T p)
        {
            
            _object.Remove(p);
            _db.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _object.ToList();
        }

        public T GetOne(int id)
        {
            return _object.Find(id);
        }

        public async Task  Update(T p)
        {
            _object.Update(p);
            _db.SaveChanges();
        }
    }
}
