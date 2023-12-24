﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3.Configuration
{
    public class AppSettingsClass
    {
        public string Port { get; private set; }
        public string Address { get; private set; }

        public AppSettingsClass(string port = "",
            string address = "")
        {
            Port = port;
            Address = address;
        }
    }
}