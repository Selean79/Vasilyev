using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using GeneralRemotePrj;

namespace RemotingClient
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpChannel channel = new HttpChannel();
            ChannelServices.RegisterChannel(channel, false);

            GeneralRemoteClass remote = (GeneralRemoteClass)Activator.GetObject(
                typeof(GeneralRemoteClass),
                "http://localhost:32121/OurFirstSoapProject.soap");

            remote.SendToSraver("Привет");
            Console.WriteLine(remote.ReplyFromSraver());
            Console.ReadLine();
        }
    }
}
