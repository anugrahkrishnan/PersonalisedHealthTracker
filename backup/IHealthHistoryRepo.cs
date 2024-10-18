using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPHT.Entities;

namespace ProjectPHT.Repo
{
    public interface IHealthHistoryRepo
    {
        ObservableCollection<HealthHistory> HistoryRead(string type, DateTime date);
        ObservableCollection<HealthHistory> ReadAllHistories();
    }

}
