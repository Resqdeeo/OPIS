using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworktasks.Attributes
{
    internal class GetAttribute : HttpMethodAttribute
    {
        public GetAttribute(string actionName) : base(actionName)
        { }
    }
}