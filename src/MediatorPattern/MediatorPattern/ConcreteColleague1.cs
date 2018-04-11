using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    class ConcreteColleague1 : IColleague
    {
        public void Join(IChatRoom chatroom)
        {
            chatroom.ColleagueList.Add(this);
            Console.WriteLine("Added Colleage: " + Name);
        }

        public void Send(IChatRoom chatroom)
        {
            chatroom.SendMessage(Console.ReadLine(), this);
        }

        public void Receive()
        {
            Console.WriteLine("Receive from Colleague 1");
        }

        public string Name { get; set; }
    }
}