using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public interface IColleague
    {
        void Join(IChatRoom c);
        void Send();
        void Receive();

        string Name { get; set; }
    }
}
