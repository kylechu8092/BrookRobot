using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotControl
{
    internal static class RobotCommand
    {
        static public String moveUp = "GOTO Z UP\r\n";
        static public String moveDown = "GOTO Z DN\r\n";
        static public String extend = "GOTO R EX\r\n";
        static public String retract = "GOTO R RE\r\n";
        static public String Home = "HOME\r\n";
        static public String contact = "HLLO\r\n";
        static public String moveTo = "GOTO\r\n";
      

    }
}
