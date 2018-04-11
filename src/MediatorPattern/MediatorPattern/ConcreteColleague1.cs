using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    class ConcreteColleague1 : IColleague
    {
        public string Name { get; set; }

        public void Join(IChatRoom chatroom)
        {
            chatroom.ColleagueList.Add(this);
            Console.WriteLine("Added Colleague: " + Name + " to " + chatroom.Name + "\n");
        }

        public void Send(IChatRoom chatroom)
        {
            chatroom.SendMessage(Console.ReadLine(), this);
        }

        public void Receive(IChatRoom chatroom, string message)
        {
            Console.WriteLine(Name + " received message " + "\"" + message + "\"" + " from " + chatroom.Name + "\n");
        }
    }
}