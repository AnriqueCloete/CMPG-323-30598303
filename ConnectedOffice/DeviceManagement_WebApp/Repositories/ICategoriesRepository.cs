using DeviceManagement_WebApp.Models;

namespace DeviceManagement_WebApp.Repositories
{
    public interface ICategoriesRepository : IGenericRepository<Category>
    {

        //This interface class contains all additional methods used in the CategoriesController
        //the implementation of these methods are contained in the CategoriesRepository class
        Category GetMostRecentCategory();

    }
}