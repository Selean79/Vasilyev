using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralRemotePrj
{
    public class GeneralRemoteClass: MarshalByRefObject
    {
        public GeneralRemoteClass()
        { }

        public void SendToSraver(string message)
        { Console.WriteLine(message); }

        public string ReplyFromSraver()
        { return "это сообщение"; }
    }
}
