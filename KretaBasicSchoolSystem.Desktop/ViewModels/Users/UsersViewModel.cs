using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;

namespace KretaBasicSchoolSystem.Desktop.ViewModels.Users
{
    public partial class UsersViewModel : BaseViewModel
    {
        private ModifyUsersViewModel _modifyUsersViewModel;
        private DeleteUsersViewModel _deleteUsersViewModel;
        private NewUsersViewModel _newUsersViewModel;

        public UsersViewModel()
        {
            _currentUsersChildView = new DeleteUsersViewModel();


            _modifyUsersViewModel = new ModifyUsersViewModel();
            _deleteUsersViewModel = new DeleteUsersViewModel();
            _newUsersViewModel = new NewUsersViewModel();
        }

        public UsersViewModel(ModifyUsersViewModel modifyUsersViewModel, DeleteUsersViewModel deleteUsersViewModel, NewUsersViewModel newUsersViewModel)
        {
            _modifyUsersViewModel = modifyUsersViewModel;
            _deleteUsersViewModel = deleteUsersViewModel;
            _newUsersViewModel = newUsersViewModel;

            _currentUsersChildView= new DeleteUsersViewModel();
        }


        [ObservableProperty]
        private BaseViewModel _currentUsersChildView;


        [RelayCommand]
        public void ShowNewUsersView()
        {
            CurrentUsersChildView = _newUsersViewModel;
        }

        [RelayCommand]
        public void ShowDeleteUsersView()
        {
            CurrentUsersChildView = _deleteUsersViewModel;
        }

        [RelayCommand]
        public void ShowModifyUsersView()
        {
            CurrentUsersChildView = _modifyUsersViewModel;
        }

    }
}
