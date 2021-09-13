using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace ServiceStart
{
    class Program
    {
        static void Main(string[] args)
        {
            string ServiceName = "Hed";
            ServiceController[] scServices;
            scServices = ServiceController.GetServices();

            foreach(ServiceController lopis in scServices) 
            {
                if(lopis.ServiceName == ServiceName) 
                {
                    Console.WriteLine("Hittad service");
                }
            }
            CreateDirectory();
            Console.ReadLine();
        }

        static void CreateDirectory() 
        {
            Directory.CreateDirectory("C:/Test/Logs");
            using(FileStream tx = new FileStream("C:/Test/Logs/TextLogg.txt", FileMode.Create, FileAccess.Write, FileShare.Read))
            {
                tx.Close();
            }
        }
        static void Logg(string input) 
        {
            using (FileStream tx = new FileStream("TextLogg.txt", FileMode.Open, FileAccess.Read, FileShare.Read)) 
            {

                using(StreamWriter sw = new StreamWriter(tx)) 
                {
                    string logTex = "Time: " + DateTime.Now + " /Information: " + input;
                    sw.Write(logTex);
                    sw.Flush();
                    
                }
                tx.Close();
            }

        }

    }
}
