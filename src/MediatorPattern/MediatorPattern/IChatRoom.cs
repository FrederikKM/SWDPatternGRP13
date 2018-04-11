using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public interface IChatRoom
    {
        string Name { get; set; }

        List<IColleague> ColleagueList { get; }

        void SendMessage(string message, IColleague colleague);
    }
}
