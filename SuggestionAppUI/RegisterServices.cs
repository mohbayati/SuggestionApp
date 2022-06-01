namespace SuggestionAppUI;

public static class RegisterServices
{
   public static void ConfigureServices(this WebApplicationBuilder builder)
   {
      // Add services to the container.
      builder.Services.AddRazorPages();
      builder.Services.AddServerSideBlazor();
      builder.Services.AddMemoryCache();

      builder.Services.AddScoped<IDbConnection, DbConnection>();
      builder.Services.AddScoped<IStatusData,MongoStatusData>();
      builder.Services.AddScoped<ICategoryData, MongoCategoryData>();
      builder.Services.AddScoped<IUserData, MongoUserData>();
      builder.Services.AddScoped<ISuggestionData,MongoSuggestionData>();
      builder.Services.AddScoped<ISuggestionData,MongoSuggestionData>();
    }
}
