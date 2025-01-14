﻿using KretaBasicSchoolSystem.Desktop.ViewModels;
using KretaBasicSchoolSystem.Desktop.ViewModels.ControlPanel;
using KretaBasicSchoolSystem.Desktop.ViewModels.Login;
using KretaBasicSchoolSystem.Desktop.ViewModels.Packages;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolClasses;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolGrades;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolSubjects;
using KretaBasicSchoolSystem.Desktop.Views;
using KretaBasicSchoolSystem.Desktop.Views.ControlPanel;
using KretaBasicSchoolSystem.Desktop.Views.Login;
using KretaBasicSchoolSystem.Desktop.Views.Packages;
using KretaBasicSchoolSystem.Desktop.Views.SchoolClasses;
using KretaBasicSchoolSystem.Desktop.Views.SchoolGrades;
using KretaBasicSchoolSystem.Desktop.Views.SchoolSubjects;
using Microsoft.Extensions.DependencyInjection;

namespace KretaDesktop.Extensions
{
    public static class ViewViewModelsExtensions
    {
        public static void ConfigureViewViewModels(this IServiceCollection services)
        {
            // MainView
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<MainView>(s => new MainView()
            {
                DataContext = s.GetRequiredService<MainViewModel>()
            });

            // LoginView
            services.AddSingleton<LoginViewModel>();
            services.AddSingleton<LoginView>(s => new LoginView()
            {
                DataContext = s.GetRequiredService<LoginViewModel>()
            });

            // ControlPanel
            services.AddSingleton<ControlPanelViewModel>();
            services.AddSingleton<ControlPanelView>(s => new ControlPanelView()
            {
                DataContext = s.GetRequiredService<ControlPanelViewModel>()
            });
            

            //School Classes
            services.AddSingleton<SchoolClassesViewModel>();
            services.AddSingleton<SchoolClassesView>(s => new SchoolClassesView()
            {
                DataContext = s.GetRequiredService<SchoolClassesViewModel>()
            });


            //School Subjects
            services.AddSingleton<SchoolSubjectsViewModel>();
            services.AddSingleton<SchoolSubjectsView>(s => new SchoolSubjectsView()
            {
                DataContext = s.GetRequiredService<SchoolSubjectsViewModel>()
            });

            //School Grades
            services.AddSingleton<SchoolGradesViewModel>();
            services.AddSingleton<SchoolGradesView>(s => new SchoolGradesView()
            {
                DataContext = s.GetRequiredService<SchoolGradesViewModel>()
            });

            //School Grades
            //Current lesson
            services.AddSingleton<CurrentLessonViewModel>();
            services.AddSingleton<CurrentLessonView>(s => new CurrentLessonView()
            {
                DataContext = s.GetRequiredService<CurrentLessonViewModel>()
            });

            //School Grades
            //Classes taught
            services.AddSingleton<ClassesTaughtViewModel>();
            services.AddSingleton<ClassesTaughtView>(s => new ClassesTaughtView()
            {
                DataContext = s.GetRequiredService<ClassesTaughtViewModel>()
            });

            //School Grades
            //End of year closing
            services.AddSingleton<EndofYearViewModel>();
            services.AddSingleton<EndofYearView>(s => new EndofYearView()
            {
                DataContext = s.GetRequiredService<EndofYearViewModel>()
            });

            //School Grades
            //End of semester closing
            services.AddSingleton<EndofSemesterViewModel>();
            services.AddSingleton<EndofSemesterView>(s => new EndofSemesterView()
            {
                DataContext = s.GetRequiredService<EndofSemesterViewModel>()
            });


            

            //Packages
            services.AddSingleton<PackagesViewModel>();
            services.AddSingleton<PackagesView>(s => new PackagesView()
            {
                DataContext = s.GetRequiredService<PackagesViewModel>()
            });

        }
    }
}
