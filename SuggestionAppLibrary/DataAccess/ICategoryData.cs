
namespace SuggestionAppLibrary.DataAccess
{
    public interface ICategoryData
    {
        Task CreateCategory(CategoryModel categoryModel);
        Task<List<CategoryModel>> GetAllCategor();
    }
}