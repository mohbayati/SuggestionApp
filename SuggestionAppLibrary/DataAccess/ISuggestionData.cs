
namespace SuggestionAppLibrary.DataAccess
{
    public interface ISuggestionData
    {
        Task CreateSeuggestion(SuggestionModel suggestion);
        Task<List<SuggestionModel>> GetAllApprovedSuggestions();
        Task<SuggestionModel> GetAllApprovedSuggestions(string id);
        Task<List<SuggestionModel>> GetAllSuggestions();
        Task<List<SuggestionModel>> GetAllSuggestionsWaitingforApproval();
        Task UpdateSuggestion(SuggestionModel suggestion);
        Task UpvoteSeuggestion(string suggestionId, string userId);
    }
}