using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Runtime.Serialization.Formatters.Binary;
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
                foreach (Machine m in from m1 in List as Machine[]
                                      where m1.Name == Name
                                      select m1)
                {
                    return m;
                }
                return null;
            }
            set
            {
                MachineModule.Machines[Name] = value;
            }
        }

        public Machine this[int Index]
        {
            get
            {
                return (Machine)List[Index];
            }
        }
        #endregion

        #region "Method"
        public void Load(Semaphore pool)
        {
            _pool = pool;
        }

        public void Save()
        {
            if (!Dirty)
                return;
            Dirty = false;
        }

        public string GetFile()
        {
            string machineSettings = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\ShipStab\\machines.bin";
            return machineSettings;
        }

        public void Import(string filename)
        {
            try
            {
                var serializer = new XmlSerializer(typeof(MachinesClass));
                FileStream fStream = new FileStream(filename, FileMode.Open, FileAccess.Read);
                MachineModule.Machines = (MachinesClass)serializer.Deserialize(fStream);
                fStream.Close();

            }
            catch(Exception ex)
            {
                Console.WriteLine("Machines::Import " + ex.Message);
                Debug.Fail(ex.Message);
            }
        }

        public void Export()
        //    Public Sub Save()
        //        If Not Dirty Then Exit Sub
        //        Export(GetFile)
        //        Dirty = False
        //    End Sub

        //    Public Sub Import(filename As String)
        //        Try
        //            Dim serializer As New XmlSerializer(GetType(MachinesClass))

        //            Dim fileStream As FileStream = New FileStream(filename, FileMode.Open, FileAccess.Read)
        //            Machines = CType(serializer.Deserialize(fileStream), MachinesClass)
        //            fileStream.Close()
        //            CheckUpgrade()

        //        Catch ex As Exception

        //            Tracelog.WriteLine("Machines::Import " & ex.Message)
        //#If DEBUG Then
        //			Debugger.Break()
        //#End If

        //        End Try

        //    End Sub

    //    Public Sub Export(ByVal filename As String)
    //    Dim serializer As New XmlSerializer(GetType(MachinesClass))
    //    Dim writer As StreamWriter

    //    Try
    //        writer = New StreamWriter(filename)
    //        serializer.Serialize(writer, Machines)
    //        writer.Close()

    //    Catch ex As UnauthorizedAccessException
    //        If(MessageBox.Show(ex.Message, My.Resources.Strings.ChangesNotSaved, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error) = DialogResult.Retry) Then
    //           Export(filename)
    //        End If

    //    Catch ex As Exception
    //        MessageBox.Show(ex.Message, My.Resources.Strings.ChangesNotSaved, MessageBoxButtons.OK, MessageBoxIcon.Error)

    //    End Try

    //End Sub

        public void Update(Machine machine)
        {
            Dirty = true;
        }

        public void Add(Machine machine)
        {
            List.Add(machine);
            machine.StatusChange += fClientList.StatusChange;

            machine.Pool = _pool;
            machine.Run();
        }

        public void Remove(string name)
        {
            Machine machine = MachineModule.Machines[name];

            if (machine == null)
                return;
            machine.Cancel();
            machine.StatusChange -= fClientList.StatusChange;
            List.Remove(machine);
            Dirty = true;
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
