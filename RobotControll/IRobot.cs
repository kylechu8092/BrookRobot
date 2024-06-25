using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotControl
{
    internal interface IRobot
    {

        bool createConnection(ref string errmsg);

        void Up();

        void Down();

        void Extend();

        void Retract();

        void SendCommand(String cmd);

        void Home();

        void Exit();

        void moveTo(int station);
    }
}
