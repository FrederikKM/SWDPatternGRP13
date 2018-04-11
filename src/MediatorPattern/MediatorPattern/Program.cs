using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var chatroom = new ConcreteChatRoom();

            var colleague1 = new ConcreteColleague1();
            var colleague2 = new ConcreteColleague2();

        }
    }
}
