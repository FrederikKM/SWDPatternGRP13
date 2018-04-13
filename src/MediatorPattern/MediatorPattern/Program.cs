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
            var chatroom2 = new ConcreteChatRoom();
            var colleague1 = new ConcreteColleague1();
            var colleague2 = new ConcreteColleague2();

            chatroom.Name = "Chatroom1";
            chatroom2.Name = "Chatroom2";
            colleague1.Name = "AlexD";
            colleague2.Name = "Frederik";

            colleague1.Join(chatroom);
            colleague2.Join(chatroom);
            colleague1.Join(chatroom2);

            colleague1.Send(chatroom);
            colleague2.Send(chatroom);
            colleague1.Send(chatroom2);
        }
    }
}
