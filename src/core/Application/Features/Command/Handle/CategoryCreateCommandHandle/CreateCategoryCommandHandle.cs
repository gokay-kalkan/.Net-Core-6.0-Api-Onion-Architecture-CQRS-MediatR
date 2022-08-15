using Application.Dto;
using Application.Interfaces;
using AutoMapper;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Command.Handle
{
    public class CreateCategoryCommandHandle : IRequestHandler<CreateCategoryCommand, CategoryModel>
    {
        private readonly ICategoryRepository repository;

        private readonly IMapper mapper;

        public CreateCategoryCommandHandle(ICategoryRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<CategoryModel> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category =  mapper.Map<Category>(request);
             await  repository.Add(category);
            return new CategoryModel { };
        }
    }
}
