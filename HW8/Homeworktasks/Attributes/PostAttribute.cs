﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworktasks.Attributes
{
    public class PostAttribute : HttpMethodAttribute
    {
        public PostAttribute(string actionName) : base(actionName)
        {
        }
    }
}