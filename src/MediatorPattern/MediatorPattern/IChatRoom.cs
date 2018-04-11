using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
       public interface IChatRoom
    {
        List<IColleague> ColleagueList { get; }

        void SendMessage(string message, IColleague colleague);
    }
    
}
