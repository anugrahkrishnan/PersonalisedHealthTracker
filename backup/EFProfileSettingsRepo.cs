using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPHT.Entities;
using ProjectPHT.Repo;

namespace ProjectPHT.EFRepo
{
    public class EFProfileSettingsRepo : IProfileRepo
    {
        private readonly PHT_DbEntities _context;

        public EFProfileSettingsRepo()
        {
            _context = new PHT_DbEntities();
        }
        public void Update(string name, DateTime date)
        {
            //throw new NotImplementedException();
            var UserToUpdate = _context.Users.Find(Session.userID);
            UserToUpdate.Name = name;
            UserToUpdate.DateOfBirth = date;
            _context.SaveChanges();

        }
    }
}
