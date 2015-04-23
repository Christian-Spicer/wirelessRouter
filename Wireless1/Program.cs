using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Wireless1
{
    class Program
    {
        static void Main(string[] args)
        {
            commandtorun("netsh wlan start hostednetwork");
        }
        static void commandtorun(string commandexecuted)
        {

            string currentstatus;
            ProcessStartInfo startInfo = new ProcessStartInfo();
            Process myprocess = new Process();
            try
            {
                startInfo.FileName = "cmd"; //
                startInfo.Verb = "runas";
                startInfo.Arguments = "/env /user:" + "Administrator" + " cmd";
                startInfo.RedirectStandardInput = true;
                startInfo.RedirectStandardOutput = true;
                startInfo.UseShellExecute = false; //'required to redirect
                startInfo.CreateNoWindow = true; // '<---- creates no window, obviously
                myprocess.StartInfo = startInfo; //
                myprocess.Start(); //
                System.IO.StreamReader SR;
                System.IO.StreamWriter SW;
                //Thread.Sleep(200);
                SR = myprocess.StandardOutput;
                SW = myprocess.StandardInput;
                SW.WriteLine(commandexecuted); // 'the command you wish to run.....
                SW.WriteLine("enter"); // 'exits command prompt window
                //Thread.Sleep(200);
                currentstatus = SR.ReadToEnd();

                SW.Close();
                SR.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                Console.ReadLine();

            }


            //  throw new NotImplementedException();
        }
   
    }
}
