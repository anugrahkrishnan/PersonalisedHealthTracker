using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ProjectPHT.Commands;
using ProjectPHT.EFRepo;
using ProjectPHT.Entities;
using ProjectPHT.Repo;

namespace ProjectPHT.ViewModels
{
    public class HealthHistoryViewModel : ViewModelBase
    {
        private int _filter = 0;
        public int Filter
        {
            get
            {
                return _filter;
            }
            set
            {
                _filter = value; OnPropertyChanged(nameof(Filter));
            }
        }
        private ObservableCollection<string> _items;

        public ObservableCollection<string> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                OnPropertyChanged(nameof(Items));
            }
        }

        private string _selectedItem;

        public string SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                OnPropertyChanged(nameof(SelectedItem));
            }
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

        //private ObservableCollection<HealthHistory>_history;
        public ObservableCollection<HealthHistory> History
        {
            get
            {
                if(Filter == 1)
                {
                    Filter = 0;
                    return _historyRepo.HistoryRead(SelectedItem, (DateTime)SelectedDate);                   
                }
                else
                {
                    return _historyRepo.ReadAllHistories();
                }
                
            }
        }


        private IHealthHistoryRepo _historyRepo = new EFHealthHistoryRepo();
        public ICommand ViewHistoryCommand { get; set; }

        public HealthHistoryViewModel()
        {
            Items = new ObservableCollection<string>
            {
                 "HeartRate",
                "BPSystolic",
                "BPDiastolic",
                "ActivityLevel"
            };

            ViewHistoryCommand = new RelayCommand(ViewHistory);

        }

        public void ViewHistory()
        {
            //ComboBoxItem selectedItem = SelectedItem;
            Filter = 1;

            OnPropertyChanged(nameof(History));


            //MessageBox.Show("History Fetched Successfully");
        }
    }
}
