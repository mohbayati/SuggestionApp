
namespace SuggestionAppLibrary.DataAccess
{
    public interface IUserData
    {
        Task CreateUser(UserModel user);
        Task<List<UserModel>> GetUsersAsync();
        Task<UserModel> GetUsersAsync(string id);
        Task<UserModel> GetUsersFromAuthenticationAsync(string objectId);
        Task UpdateUser(UserModel user);
    }
}