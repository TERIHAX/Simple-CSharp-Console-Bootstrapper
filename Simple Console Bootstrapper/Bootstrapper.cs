using System;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using Simple_Console_Bootstrapper;
using Simple_Console_Bootstrapper.Simple_Console_Bootstrapper;

namespace Simple_Console_Bootstrapper
{
    namespace Simple_Console_Bootstrapper
    { // Also, please don't criticize me for my code, I'm not the best at C#.
        class Bootstrapper {
            public static string fileName = "Never_Gonna_Give_You_Up.txt"; // Put your file name here. (Make sure you put the file extension at the back) E.g. If a file name is called Lol.exe don't just call it Lol, else it won't work. E.g.2 If a file is called xD.txt don't just call it xD.
            public static string directDownloadURL = "https://github.com/TERIHAX/Never_Gonna_Give_You_Up/releases/download/Never_Gonna_Give_You_Up/Never_Gonna_Give_You_Up.txt"; // Put your file download link here. (Needs to be a direct link)

// ----------------------------------DO NOT CHANGE ANYTHING HERE IF YOU DON'T UNDERSTAND-------------------------------\\
            static void Main(string[] args)
            {
                Console.Title = "Bootstrapper";
                Console.Write("[Bootstrapper] Loading...");
                Task.Delay(300);
                Console.Write("\r\n[Bootstrapper] Downloading Files...");
                using (var wc = new WebClient())
                {
                    wc.DownloadFile(directDownloadURL, fileName); // Don't mess anything here.
                    Task.Delay(250);
                    if (File.Exists(fileName))
                    {
                        Console.Write("\r\n[Bootstrapper] Download Complete!");
                        Task.Delay(300);
                        Console.Write("\r\n[Bootstrapper] Press any key to Exit...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Write("\r\n[Bootstrapper] Download Failed.");
                        Task.Delay((int)0.15);
                        Console.Write("\r\n[Bootstrapper] Error: The link might have been not a direct link, or the file name was incorrect.");
                        Task.Delay((int)0.3);
                        Console.Write("\r\n[Bootstrapper] Press any key to Exit...");
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}
