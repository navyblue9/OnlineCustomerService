﻿using System;
using System.Net.WebSockets;
using System.Threading.Tasks;

namespace Service
{
    public interface IClientWebSocket
    {
        String Name { set; get; }
        String Mail { set; get; }
        String Phone { set; get; }
        String Question { set; get; }
        String WebSocketId { set; get; }
        String WebSocketServiceId { set; get; }
        WebSocket WebSocket { set; get; }
        void Reset();
        Task Start();
    }
}
