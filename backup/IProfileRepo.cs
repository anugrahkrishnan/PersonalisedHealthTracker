using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPHT.Repo
{
    public interface IProfileRepo
    {
        void Update (string name, DateTime date);
    }
}
