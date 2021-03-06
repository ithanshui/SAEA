﻿using SAEA.RedisSocket.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace SAEA.RedisSocket.Interface
{
    public interface IClient
    {
        bool IsConnected { get; set; }

        string Auth(string password);

        string Ping();

        string Select(int dbIndex = 0);

        int DBSize();

        string Type(string key);

        string Info();

        string SlaveOf(string ipPort = "");

        bool IsMaster();

        RedisDataBase GetDataBase(int dbIndex = -1);
    }
}
