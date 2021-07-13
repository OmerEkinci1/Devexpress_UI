using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Socket_Connection.Connection
{
    public class UDPserver
    {
        int recv;
        byte[] data = new byte[1024];

        IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 904);

        Socket newSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        newSocket.Bind(endPoint);

        Console.WriteLine("Waiting for a client");

        IPEndPoint sender = new IPEndPoint(IPAddress.Any, 904);
        EndPoint tempRemote = (EndPoint)sender;

        recv = newSocket.ReceiveFrom(data, ref tmpRemote);

        Console.Write("Message received from {0}", tmpRemote.ToString());
        Console.WriteLine(Encoding.ASCII.GetString(data,0,recv));

        string welcome = "Welcome to my server";
        data = Encoding.ASCII.GetBytes(welcome);

        if (newSocket.connected)
            newSocket.Send(data)

        while(true)
        {
            if (!newSocket.Connected)
	        {
                Console.WriteLine("Client Disconnected");
                break;
	        }

            data = new byte[1024];
            recv = newSocket.ReceiveFrom(data, ref tmpRemote);

            if (recv == 0)
	            break;

            Console.WriteLine(Encoding.ASCII.GetString(data, 0, recv));
        }
        newSocket.Close();
    }
}
