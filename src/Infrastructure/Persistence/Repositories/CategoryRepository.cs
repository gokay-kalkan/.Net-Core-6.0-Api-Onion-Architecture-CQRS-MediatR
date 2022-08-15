using Application.Interfaces;
using Domain;
using Persistence.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class CategoryRepository : GenericRepository<Category, Context>, ICategoryRepository
    {
        private Context context;
        public CategoryRepository(Context context) : base(context)
        {
            this.context = context;
        }


    }
}
