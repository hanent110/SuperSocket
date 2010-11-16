﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;

namespace SuperSocket.SocketServiceCore.Protocol
{
    public interface IAsyncProtocol
    {
        ICommandAsyncReader CreateAsyncCommandReader();
    }
}
