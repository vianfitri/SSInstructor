using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SSInstructor.Class
{
    static class MachineModule
    {
        public static MachinesClass Machines = new MachinesClass();
    }

    public class MachinesClass : CollectionBase
    {
        public bool Dirty = false;
        private static Semaphore _pool;


    }
}
