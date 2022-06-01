
namespace SuggestionAppLibrary.DataAccess
{
    public interface IStatusData
    {
        Task CreateStatus(StatusModel statusModel);
        Task<List<StatusModel>> GetAllStatuses();
    }
}