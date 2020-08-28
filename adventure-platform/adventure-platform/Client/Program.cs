using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using adventureplatform.Client.Helpers;
using Blazor.FileReader;
using adventureplatform.Client.Repository;
using Microsoft.AspNetCore.Components.Authorization;
using adventureplatform.Client.Auth;

namespace adventureplatform.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddOptions();

            builder.Services.AddAuthorizationCore();

            builder.Services.AddScoped<JWTAuthenticationStateProvider>();

                builder.Services.AddScoped<AuthenticationStateProvider, JWTAuthenticationStateProvider>(
                    provider => provider.GetRequiredService<JWTAuthenticationStateProvider>()
                );
                builder.Services.AddScoped<ILoginService, JWTAuthenticationStateProvider>(
                    provider => provider.GetRequiredService<JWTAuthenticationStateProvider>()
                );


            builder.Services.AddFileReaderService(options => options.InitializeOnFirstCall = true);
            builder.Services.AddScoped<IHttpService, HttpService>();
            builder.Services.AddScoped<IGenreRepository, GenreRepository>();
            builder.Services.AddScoped<IAdventureRepository, AdventureRepository>();
            builder.Services.AddScoped<IChapterRepository, ChapterRepository>();
            builder.Services.AddScoped<ILinkRepository, LinkRepository>();
            builder.Services.AddScoped<IAccountRepository, AccountRepository>();
            builder.Services.AddScoped<IUserRepository, UserRepository>();
            builder.Services.AddScoped<IUserFavouriteRepository, UserFavouriteRepository>();

            await builder.Build().RunAsync();
        }
    }
}
