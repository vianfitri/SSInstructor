using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SSInstructor.Class
{
    [DebuggerDisplay("{Name,nq}")]
    [Serializable]
    public class Machine
    {
        public enum ShutdownMethods
        {
            WMI,
            Custom,
            Legacy
        }

        public enum StatusCodes {
            Online,
            Offline,
            Unknown,
            Fail,
            Uninitialized
        }

        public enum TraceMethods {
            WriteLine,
            Indent,
            UnIndent
        }
    }
}
