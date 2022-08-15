using Application.Dto;
using Application.Features.Command.CategoryUpdateCommand;
using Application.Interfaces;
using AutoMapper;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Command.Handle.CategoryUpdateHandle
{
    public class UpdateCategoryCommandHandle : IRequestHandler<UpdateCategoryCommand, CategoryModel>
    {
        private readonly ICategoryRepository repository;

        private readonly IMapper mapper;

        public UpdateCategoryCommandHandle(ICategoryRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<CategoryModel> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            
            var dto = mapper.Map<Category>(request);
            await repository.Update(dto);
            return new CategoryModel { };
        }
    }
}
