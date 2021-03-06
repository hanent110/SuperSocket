using System;
using System.Collections.Specialized;
using SuperSocket.Server;

namespace SuperSocket.WebSocket.Server
{
    public class WebSocketSession : AppSession
    {
        public bool Handshaked { get; internal set; }

        public NameValueCollection HeaderItems { get; internal set; }
    }
}