using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ProjectPHT.Commands;
using ProjectPHT.EFRepo;
using ProjectPHT.Repo;

namespace ProjectPHT.ViewModels
{
    public class ProfileSettingsViewModel : ViewModelBase
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(nameof(Name)); }
        }

        private DateTime? _selectedDate;

        public DateTime? SelectedDate
        {
            get { return _selectedDate; }
            set
            {
                _selectedDate = value;
                OnPropertyChanged(nameof(SelectedDate));
            }
        }

        private string _notification;
        public string Notification
        {
            get { return _notification; }
            set { _notification = value; OnPropertyChanged(nameof(Notification)); }
        }

        //private string _warning;
        //public string Warning
        //{
        //    get { return _warning; }
        //    set { _warning = value; OnPropertyChanged(nameof(Warning)); }
        //}


        private IProfileRepo _profileRepo = new EFProfileSettingsRepo();
        public ICommand UpdateCommand { get; }

        public ProfileSettingsViewModel()
        {
            UpdateCommand = new RelayCommand(UpdateUser);

        }

        void UpdateUser()
        {
            try
            {
                _profileRepo.Update(Name, (DateTime)SelectedDate);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(messageBoxText: "An error occurred: " +      ex.Message,
                    caption: "Error",
                    button: MessageBoxButton.OK,
                    icon: MessageBoxImage.Error);
            }
        }
    }
}
