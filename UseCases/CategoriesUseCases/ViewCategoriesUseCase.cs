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
    public class ViewCategoriesUseCase : IViewCategoriesUseCase
    {
        private readonly ICategoryRepository _categoryRepository;

        public ViewCategoriesUseCase(ICategoryRepository categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }
        public IEnumerable<Category> Execute()
        {
            return _categoryRepository.GetCategories();
        }
    }
}
