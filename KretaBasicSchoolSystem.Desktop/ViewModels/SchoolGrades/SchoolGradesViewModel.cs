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

        public SchoolGradesViewModel()
        {
            _currentSchoolGradesChildView = new ClassesTaughtViewModel();
            _currentSchoolGradesChildView = new EndofSemesterViewModel();
            _currentSchoolGradesChildView = new EndofYearViewModel();



            _classesTaughtViewModel = new ClassesTaughtViewModel();
            _endofSemesterViewModel = new EndofSemesterViewModel();
            _endofYearViewModel = new EndofYearViewModel();


        }

        public SchoolGradesViewModel(ClassesTaughtViewModel classesTaughtViewModel, EndofSemesterViewModel endofSemesterViewModel, EndofYearViewModel endofYearViewModel)
        {
            _classesTaughtViewModel = classesTaughtViewModel;
            _endofSemesterViewModel = endofSemesterViewModel;
            _endofYearViewModel = endofYearViewModel;


            _currentSchoolGradesChildView = new ClassesTaughtViewModel();
            _currentSchoolGradesChildView = new EndofSemesterViewModel();
            _currentSchoolGradesChildView = new EndofYearViewModel();
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


    }
}
