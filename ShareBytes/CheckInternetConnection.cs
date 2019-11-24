using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace ShareBytes
{
    class CheckInternetConnection
    {  
        public bool IsConnectedToInternet()
        {
        string host = "www.google.com";  
        bool result = false;
        Ping p = new Ping();
        try
        {
            PingReply reply = p.Send(host, 3000);
                if (reply.Status == IPStatus.Success)
                    return true;
                else
                    return true;
        }
        catch { }
        return result;
    }
}
}
