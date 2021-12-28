using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces;

namespace UseCases.CategoriesUseCases
{
    public class GetCategoryByIdUseCase : IGetCategoryByIdUseCase
    {
        private readonly ICategoryRepository _categoryRepository;

        public GetCategoryByIdUseCase(ICategoryRepository categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }

        public Category Execute(int categoryId)
        {
            return _categoryRepository.GetCategoryById(categoryId);
        }
    }
}
