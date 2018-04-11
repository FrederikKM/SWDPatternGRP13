using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public interface IColleague
    {
        string Name { get; set; }

        void Join(IChatRoom chatroom);
        void Send(IChatRoom chatroom);
        void Receive(IChatRoom chatroom, string message);
    }
}
