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
    public class CategoryGetByIdQueryHandle : IRequestHandler<CategoryGetByIdQuery, CategoryModel>
    {
        private readonly ICategoryRepository repository;

        private readonly IMapper mapper;

        public CategoryGetByIdQueryHandle(ICategoryRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public Task<CategoryModel> Handle(CategoryGetByIdQuery request, CancellationToken cancellationToken)
        {
            var category = repository.GetOne(request.Id);

            var dto=mapper.Map<CategoryModel>(category);

            return Task.FromResult(dto);
        }
    }
}
