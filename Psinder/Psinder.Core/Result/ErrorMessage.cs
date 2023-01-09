using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psinder.Core.Result
{
    public struct ErrorMessage
    {
        public string TargetName { get; set; }
        public string Message { get; set; }

        public ErrorMessage(string targetName, string message)
        {
            Message = message;
            TargetName = targetName;
        }
    }
}
