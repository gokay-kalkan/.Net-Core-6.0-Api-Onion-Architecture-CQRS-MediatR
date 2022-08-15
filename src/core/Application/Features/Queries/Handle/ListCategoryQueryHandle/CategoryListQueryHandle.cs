using Application.Dto;
using Application.Interfaces;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Queries.Handle
{
    public class CategoryListQueryHandle : IRequestHandler<CategoryListQuery, List<CategoryModel>>
    {
        private readonly ICategoryRepository repository;

        private readonly IMapper mapper;

        public CategoryListQueryHandle(ICategoryRepository repository,IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
       

        public async Task<List<CategoryModel>> Handle(CategoryListQuery request, CancellationToken cancellationToken)
        {
            var list = repository.GetAll();
            var mapping = mapper.Map<List<CategoryModel>>(list);
            return mapping;
        }
    }
}
