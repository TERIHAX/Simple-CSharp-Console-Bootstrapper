using System;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using Simple_Console_Bootstrapper;

namespace Simple_Console_Bootstrapper
{
    namespace Simple_Console_Bootstrapper
    {
        class Bootstrapper
        {
            public static string fileName = "Never_Gonna_Give_You_Up.txt"; // Put your file name here. (Make sure you put the file extension at the back) E.g. If a file name is called Lol.exe don't just call it Lol, else it won't work. E.g.2 If a file is called xD.txt don't just call it xD.
            public static string downloadLink = "https://github.com/TERIHAX/Never_Gonna_Give_You_Up/releases/download/Never_Gonna_Give_You_Up/Never_Gonna_Give_You_Up.txt"; // Put your file download link here. (Needs to be a direct link)

// --------------------------------DO NOT CHANGE ANYTHING HERE IF YOU DON'T UNDERSTAND-------------------------------\\
            static void Main(string[] args)
            {
                Console.Write("[Bootstrapper] "); // Yes all of these spaces are on purpose or else it will look very wierd.
                Task.Delay((int) 0.3);
                Console.Write("Loading...");
                
                Task.Delay((int) 0.3);
                Console.Write("\r\n[Bootstrapper] ");
                Task.Delay((int) 0.3);
                Console.Write("Downloading Files...");
                using (var wc = new WebClient())
                {
                    wc.DownloadFile(downloadLink, fileName); // Don't mess anything here.
                    Task.Delay(1);
                    if (File.Exists(fileName))
                    {
                        Console.Write("\r\n[Bootstrapper] ");
                        Task.Delay((int) 0.3);
                        Console.Write("Download Complete!");
                        Task.Delay((int) 0.3);
                        Console.Write("\r\n[Bootstrapper] ");
                        Task.Delay((int) 0.3);
                        Console.Write("Exiting...");
                        Task.Delay((int) 4.5);
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.Write("\r\n[Bootstrapper] ");
                        Task.Delay((int) 0.3);
                        Console.Write("Download Failed.");
                        Task.Delay((int) 0.15);
                        Console.Write("\r\n[Bootstrapper] ");
                        Task.Delay((int) 0.3);
                        Console.Write("Error: The link might have been not a direct link.");
                    }
                }
            }
        }
    }

}
