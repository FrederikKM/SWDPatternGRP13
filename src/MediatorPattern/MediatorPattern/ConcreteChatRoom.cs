using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class ConcreteChatRoom : IChatRoom
    {
        public List<IColleague> ColleagueList { get; } = new List<IColleague>();

        public ConcreteChatRoom()
        {

        }
        public void SendMessage(string message, IColleague colleague)
        {
            
            Console.WriteLine(colleague.Name + "Has sent: " + message);
        }
         
    }
}
