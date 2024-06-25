using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Configuration;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using System.Net;
using System.Runtime.InteropServices;

namespace RobotControl
{
    public class BrookRobot : IRobot
    {

        private Boolean _isOnline = false;
        public delegate void ConnectionChangedHandler(bool online);
        public event ConnectionChangedHandler RobotStateChanged;


        public bool IsOnline
        {
            get { return _isOnline; }
            set
            {
                _isOnline = value;
                RobotStateChanged(value);
            }
        }

        private string _IP;
        private int _Port;
        private int _retries;
        public string IpAddress { get => _IP; set => _IP = value; }

        public int retries { get => _retries; set => _retries = value; }
        public int Port { get => _Port; set => _Port = value; }

        

        private Socket _sender;

        private ThreadManager threadList = new ThreadManager();


        public bool createConnection(ref string errmsg)
        {
            try
            {
                SocketConnection();
                threadList.robotConnectionThread = new Thread(Communication);
                //threadList.robotConnectionThread.Start();
                _isOnline = true;
                return true;
            }
            catch (Exception ex)
            {
                errmsg = ex.Message;
                return false;
            }
            finally
            { }
        }

        

        public void Communication()
        {
            byte[] responseArray;
            byte[] data;
            while (true)
            {
                try
                {
                    data = Encoding.ASCII.GetBytes(RobotCommand.contact);
                    _sender.Send(data);
                    responseArray = new byte[1024];
                    _sender.Receive(responseArray);
                    string readData = Encoding.ASCII.GetString(responseArray);
                    if (readData == "Hello" || readData == ":" || readData == "_RDY")
                    {
                        continue;
                    }
                    else
                    {
                        throw new Exception("Disconnected from robot");
                    }
                }
                catch (Exception e)
                {
                    throw new Exception();
                }
            }
        }

        public void SocketConnection()
        {
            try
            {
                IPAddress ipAddr = IPAddress.Parse(_IP);
                IPEndPoint localEndPoint = new IPEndPoint(ipAddr, _Port);
                _sender = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                _sender.Connect(localEndPoint);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        public void moveTo(int station)
        {
            try
            {

            }
            catch
            {

            }
        }



        public void Up()
        {

            try
            {
                int currentRetries = retries;
                while (currentRetries > 0)
                {
                    //convert the command to ASCII to be sent
                    byte[] messageSent = Encoding.ASCII.GetBytes(RobotCommand.moveUp);
                    _sender.Send(messageSent);
                    //prepares a buffer to receive the response
                    byte[] messageReceived = new byte[messageSent.Length];
                    //receives the response from the robot
                    _sender.Receive(messageReceived);
                    //convert received bytes back to a string and stores in read
                    string read = Encoding.ASCII.GetString(messageReceived, 0, messageReceived.Length);
                    if (read == "_RDY")
                    {
                        break;
                    }
                    currentRetries--;
                }
            }

            catch (Exception e)
            {
                throw new Exception();
            }
        }





        public void Down()
        {
            try
            {
                int currentRetries = retries;
                while (currentRetries > 0)
                {
                    byte[] cmd = Encoding.ASCII.GetBytes(RobotCommand.moveDown);
                    _sender.Send(cmd);
                    byte[] response = new byte[cmd.Length];
                    _sender.Receive(response);
                    string newRead = Encoding.ASCII.GetString(response, 0, response.Length);
                    if (newRead == "_RDY")
                    {
                        break;
                    }
                    currentRetries--;
                }
            }

            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void Extend()
        {
            try
            {
                int currentRetries = retries;
                while (currentRetries > 0)
                {
                    byte[] cmd = Encoding.ASCII.GetBytes(RobotCommand.extend);
                    _sender.Send(cmd);
                    byte[] response = new byte[cmd.Length];
                    _sender.Receive(response);
                    string newRead = Encoding.ASCII.GetString(response, 0, response.Length);
                    if (newRead == "_RDY")
                    {
                        break;
                    }
                    currentRetries--;
                }
            }

            catch (Exception e)
            {
                throw new Exception();
            }
        }
        public void Retract()
        {
            try
            {
                int currentRetries = retries;
                while (currentRetries > 0)
                {
                    byte[] cmd = Encoding.ASCII.GetBytes(RobotCommand.retract);
                    _sender.Send(cmd);
                    byte[] response = new byte[cmd.Length];
                    _sender.Receive(response);
                    string newRead = Encoding.ASCII.GetString(response, 0, response.Length);
                    if (newRead == "_RDY")
                    {
                        break;
                    }
                    currentRetries--;
                }
            }

            catch (Exception e)
            {
                throw new Exception();
            }
        }
        public void Home()
        {
            try
            {
                int currentRetries = retries;
                while (currentRetries > 0)
                {
                    byte[] cmd = Encoding.ASCII.GetBytes(RobotCommand.Home);
                    _sender.Send(cmd);
                    byte[] response = new byte[cmd.Length];
                    _sender.Receive(response);
                    string newRead = Encoding.ASCII.GetString(response, 0, response.Length);
                    if (newRead == "_RDY")
                    {
                        break;
                    }
                    currentRetries--;
                }
            }

            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void SendCommand(String cmd)
        {
            try
            {
                int currentRetries = retries;
                while (currentRetries > 0)
                 {
                    byte[] send = Encoding.ASCII.GetBytes(cmd + "\r\n");
                    _sender.Send(send);
                    byte[] response = new byte[1024];
                    _sender.Receive(response);
                    string read = Encoding.ASCII.GetString(response, 0, response.Length);
                    //Need to correct
                    if (read == "_RDY")
                    {
                        break;
                    }
                    currentRetries--;
                }
            }
            catch (Exception ex)
            {
                //do something
                throw new NotImplementedException();
            }
        }

        public void Exit()
        {
            Environment.Exit(0);
        }

        public void Close()
        {
            threadList.connectionThread?.Abort();
            threadList.robotConnectionThread?.Abort();
        }

    }
}
