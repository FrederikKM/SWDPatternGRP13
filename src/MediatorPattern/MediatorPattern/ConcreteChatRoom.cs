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
        
        public string Name { get;set;}

        public void SendMessage(string message, IColleague colleague)
        {
            foreach(var x in ColleagueList)
            {
                if (x != colleague)
                {
                    Console.WriteLine("\n" + colleague.Name + " has sent: " + message + " to " + x.Name + "\n");
                    x.Receive(this, message);
                }
            }
        }
         
    }
}
