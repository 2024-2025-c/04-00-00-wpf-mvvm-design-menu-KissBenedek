using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FontAwesome.Sharp;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;
using KretaBasicSchoolSystem.Desktop.ViewModels.ControlPanel;
using KretaBasicSchoolSystem.Desktop.ViewModels.Packages;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolClasses;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolGrades;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolSubjects;

namespace KretaBasicSchoolSystem.Desktop.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        private ControlPanelViewModel _controlPanelViewModel;
        private SchoolClassesViewModel _schoolClassesViewModel;
        private SchoolSubjectsViewModel _schoolSubjectsViewModel;
        private SchoolGradesViewModel _schoolGradesViewModel;
        private PackagesViewModel _packagesViewModel;

        public MainViewModel()
        {
            _controlPanelViewModel = new ControlPanelViewModel();
            _schoolClassesViewModel = new SchoolClassesViewModel();
            _schoolSubjectsViewModel = new SchoolSubjectsViewModel();
            _schoolGradesViewModel = new SchoolGradesViewModel();
            _packagesViewModel = new PackagesViewModel();
        }

        public MainViewModel(
            ControlPanelViewModel controlPanelViewModel, 
            SchoolClassesViewModel schoolClassesViewModel,
            SchoolSubjectsViewModel schoolSubjectsViewModel,
            SchoolGradesViewModel schoolGradesViewModel,
            PackagesViewModel packagesViewModel
            )
        {
            _controlPanelViewModel = controlPanelViewModel;
            _schoolClassesViewModel = schoolClassesViewModel;
            _schoolSubjectsViewModel = schoolSubjectsViewModel;
            _schoolGradesViewModel = schoolGradesViewModel;
            _packagesViewModel = packagesViewModel;


            CurrentChildView = _controlPanelViewModel;
            ShowDashbord();
        }

        [ObservableProperty]
        private string _caption = string.Empty;

        [ObservableProperty]
        private IconChar _icon = new IconChar();

        [ObservableProperty]
        private BaseViewModel _currentChildView;

        [RelayCommand]
        public void ShowDashbord()
        {
            Caption = "Vezérlőpult";
            Icon=IconChar.SolarPanel;
            CurrentChildView = _controlPanelViewModel;
        }

        [RelayCommand]
        public void ShowPackages()
        {
            Caption = "Csomagok";
            Icon = IconChar.Sun;
            CurrentChildView = _packagesViewModel;
        }

        [RelayCommand]
        public void ShowSchoolClasses()
        {
            Caption = "Osztályok";
            Icon = IconChar.ChalkboardUser;
            CurrentChildView = _schoolClassesViewModel;
        }

        [RelayCommand]
        public void ShowSchoolSubjects()
        {
            Caption = "Tantárgyak";
            Icon = IconChar.GraduationCap;
            CurrentChildView = _schoolSubjectsViewModel;
        }

        [RelayCommand]
        public void ShowSchoolGrades()
        {
            Caption = "Osztályzatok";
            Icon = IconChar.ListNumeric;
            CurrentChildView = _schoolGradesViewModel;
        }

    }
}
