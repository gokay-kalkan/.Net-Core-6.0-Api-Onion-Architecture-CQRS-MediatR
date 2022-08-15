using Application.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Queries
{
    public class CategoryGetByIdQuery:IRequest<CategoryModel>
    {
        public int Id { get; set; }
    }
}
