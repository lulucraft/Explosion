﻿using Explosion.Context.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Explosion
{
    public static partial class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>()
                   .UseMauiCommunityToolkit()
                   .UseMauiCommunityToolkitMarkup()
                   .ConfigureFonts(fonts =>
                   {
                       fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                       fonts.AddFont("OpenSans-SemiBold.ttf", "OpenSansSemiBold");
                       fonts.AddFont("MaterialDesign-Webfont.ttf", "MaterialDesignIcons");
                       fonts.AddFont("FontAwesome-Solid900.ttf", "FontAwesomeIcons");
                   });

            builder.Services.AddSingleton<IDialogService, DialogService>();
            builder.Services.AddSingleton<INavigationService, NavigationService>();
            builder.Services.AddSingleton<EventsViewModel>();
            builder.Services.AddSingleton<EventsPage>();
            builder.Services.AddSingleton<SearchViewModel>();
            builder.Services.AddSingleton<SearchPage>();
            builder.Services.AddSingleton<SettingsViewModel>();
            builder.Services.AddSingleton<SettingsPage>();
            builder.Services.AddTransient<LoginViewModel>();
            builder.Services.AddTransient<LoginPage>();
            builder.Services.AddTransient<NewEventViewModel>();
            builder.Services.AddTransient<NewEventPage>();
            
            builder.Services.AddSingleton<IExplosionService, ExplosionService>();
            builder.Services.AddSingleton<AccueilViewModel>();
            builder.Services.AddSingleton<AccueilPage>();
            builder.Services.AddSingleton<ListeExplosionViewModel>();
            builder.Services.AddSingleton<ListeExplosionPage>();
            builder.Services.AddSingleton<FicheExplosionViewModel>();
            builder.Services.AddSingleton<FicheExplosionPage>();
            builder.Services.AddSingleton<IPaysService, PaysService>();
            builder.Services.AddSingleton<ListePaysPage>();
            builder.Services.AddSingleton<ListePaysViewModel>();
            builder.Services.AddSingleton<EditionPaysPage>();
            builder.Services.AddSingleton<EditionPaysViewModel>();

            // Ajouter la configuration des secrets utilisateur
            var configuration = new ConfigurationBuilder()
                .Build();

            builder.Configuration.AddConfiguration(configuration);

            // Configurer le contexte de base de données
            object dbContext = builder.Services.AddDbContext<TpExplosionContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            // Enregistrer le service de configuration pour l'injection de dépendances
            builder.Services.AddSingleton<IConfiguration>(configuration);

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }

    }
}
