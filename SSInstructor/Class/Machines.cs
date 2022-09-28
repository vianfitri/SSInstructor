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
using System.Windows.Forms;
using SSInstructor.Class;
using SSInstructor.Forms;
using Machines;

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

        #region "Property"
        public Machine this[string Name]
        {
            get
            {
                foreach (Machine m in from m1 in List.
                                      where m1.Name == Name
                                      select m1)
                {
                    return m;
                }
                return null;
            }
            set
            {
                List = value;
            }
        }
        #endregion

        #region "Method"
        public void Add(Machine machine)
        {
            List.Add(machine);
            machine.StatusChange += fClientList.StatusChange;

            machine.Pool = _pool;
            machine.Run();
        }

        public void Remove(string name)
        {

        }

        public void Close()
        {
            foreach(Machine machine in List)
            {
                machine.Cancel();
                machine.StatusChange -= fClientList.StatusChange;
            }
        }
        #endregion
    }
}
