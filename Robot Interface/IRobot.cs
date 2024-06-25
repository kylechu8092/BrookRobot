using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Interface
{
    internal interface IRobot
    {
        void IsConnected();

        void Home();

        void Up();

        void Down();

        void Exit();

        void Retract();
        
        void Extend();

        void SendCommand();
    }
}
