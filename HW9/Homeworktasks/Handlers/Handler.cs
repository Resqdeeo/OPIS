﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Homeworktasks.Handlers
{
    public abstract class Handler
    {
        public Handler? Successor { get; set; }
        public abstract void HandleRequest(HttpListenerContext context);
    }
}