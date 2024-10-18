using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPHT.Entities;
using ProjectPHT.Repo;

namespace ProjectPHT.EFRepo
{
    public class EFHealthHistoryRepo : IHealthHistoryRepo
    {
        private readonly PHT_DbEntities _context;

        public EFHealthHistoryRepo() 
        {
            _context = new PHT_DbEntities();

        }

        public ObservableCollection<HealthHistory> HistoryDataList = new ObservableCollection<HealthHistory>();

        public ObservableCollection<HealthHistory> HistoryRead(string type, DateTime date)
        {
            //using (var context = new ApplicationDbContext())
            //{
                var histories = _context.HealthHistories
                    .Where(h => h.UserID == 1 &&
                                h.MetricType == type &&
                                h.RecordedAt > date)
                    .ToList();

                HistoryDataList.Clear(); // Clear existing data
                foreach (var history in histories)
                {
                    HistoryDataList.Add(history);
                }
            //}
            return HistoryDataList;
        }
        public ObservableCollection<HealthHistory> ReadAllHistories()
        {
            return new ObservableCollection<HealthHistory>(_context.HealthHistories.ToList());
        }
    }
}
