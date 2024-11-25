using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolSubjects;


namespace KretaBasicSchoolSystem.Desktop.ViewModels.SchoolGrades
{
    public partial class SchoolGradesViewModel : BaseViewModel
    {
        private ClassesTaughtViewModel _classesTaughtViewModel;
        private EndofSemesterViewModel _endofSemesterViewModel;
        private EndofYearViewModel _endofYearViewModel;
        private CurrentLessonViewModel _currentLessonViewModel;

        public SchoolGradesViewModel()
        {
            _currentSchoolGradesChildView = new ClassesTaughtViewModel();
            _currentSchoolGradesChildView = new EndofSemesterViewModel();
            _currentSchoolGradesChildView = new EndofYearViewModel();
            _currentSchoolGradesChildView = new CurrentLessonViewModel();



            _classesTaughtViewModel = new ClassesTaughtViewModel();
            _endofSemesterViewModel = new EndofSemesterViewModel();
            _endofYearViewModel = new EndofYearViewModel();
            _currentLessonViewModel = new CurrentLessonViewModel();


        }

        public SchoolGradesViewModel(ClassesTaughtViewModel classesTaughtViewModel, EndofSemesterViewModel endofSemesterViewModel, EndofYearViewModel endofYearViewModel, CurrentLessonViewModel currentLessonViewModel)
        {
            _classesTaughtViewModel = classesTaughtViewModel;
            _endofSemesterViewModel = endofSemesterViewModel;
            _endofYearViewModel = endofYearViewModel;
            _currentLessonViewModel = currentLessonViewModel;


            _currentSchoolGradesChildView = new ClassesTaughtViewModel();
            _currentSchoolGradesChildView = new EndofSemesterViewModel();
            _currentSchoolGradesChildView = new EndofYearViewModel();
            _currentSchoolGradesChildView = new CurrentLessonViewModel();
        }

        [ObservableProperty]
        private BaseViewModel _currentSchoolGradesChildView;


        [RelayCommand]
        public void ShowClassesTaughtView()
        {
            CurrentSchoolGradesChildView = _classesTaughtViewModel;
        }

        [RelayCommand]
        public void ShowEndofSemesterView()
        {
            CurrentSchoolGradesChildView = _endofSemesterViewModel;
        }

        [RelayCommand]
        public void ShowEndofYearView()
        {
            CurrentSchoolGradesChildView = _endofYearViewModel;
        }

        [RelayCommand]
        public void ShowCurrentLessonView() 
        {
            CurrentSchoolGradesChildView = _currentLessonViewModel;
        }


    }
}
