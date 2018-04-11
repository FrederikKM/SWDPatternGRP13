using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    class ConcreteColleague2 : IColleague
    {
        public void Join(IChatRoom c)
        {
            c.ColleagueList.Add(this);
            Console.WriteLine("Added Colleage: " + Name);
        }

        public void Send(IChatRoom chatroom)
        {
            chatroom.SendMessage(Console.ReadLine(), this);
        }

        public void Receive()
        {
            Console.WriteLine("Receive from Colleague 2");
        }

        public string Name { get; set; }
    }
}