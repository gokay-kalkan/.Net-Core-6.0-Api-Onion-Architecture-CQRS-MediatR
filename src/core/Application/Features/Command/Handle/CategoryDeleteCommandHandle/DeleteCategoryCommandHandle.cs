using Application.Dto;
using Application.Interfaces;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Command.Handle
{
    public class DeleteCategoryCommandHandle : IRequestHandler<DeleteCategoryCommand, CategoryModel>
    {
        private readonly ICategoryRepository repository;

        private readonly IMapper mapper;

        public DeleteCategoryCommandHandle(ICategoryRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public Task<CategoryModel> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = repository.GetOne(request.Id);
            repository.Delete(category);

            var dto = mapper.Map<CategoryModel>(category);

            return Task.FromResult(dto);
        }
    }
}
