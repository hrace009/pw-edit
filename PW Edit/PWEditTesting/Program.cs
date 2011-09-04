using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PWEditLib.NPCGenData;
using System.IO;
using System.Net;

namespace PWEditTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            #region hideme
            String temp = Path.GetTempPath() + "{6294C1D2-CD9C-4F86-B80C-686B45217497}";
            if (!Directory.Exists(temp))
            {
                Directory.CreateDirectory(temp);
            }
            temp += "\\";
            WebClient wc = new WebClient();
            if (!File.Exists(temp + "npcgen.data"))
            {
                Console.WriteLine("Downloading npcgen.data for testing");
                Console.WriteLine();
                //progress = new ProgressBar.ProgressBar(32);
                System.Threading.Thread.Sleep(100);
                wc.DownloadFileAsync(new Uri("http://pw-edit.googlecode.com/svn/trunk/PW Edit/PWEditTesting/npcgen.data"), temp + "npcgen.data");
            }
            wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(wc_DownloadProgressChanged);
            while (true)
            {
                if (!wc.IsBusy)
                {
                    if (!File.Exists(temp + "npcgen2.data"))
                    {
                        Console.WriteLine();
                        Console.WriteLine("Downloading npcgen2.data for testing");
                        Console.WriteLine();
                        //progress = new ProgressBar.ProgressBar(32);
                        System.Threading.Thread.Sleep(100);
                        wc.DownloadFileAsync(new Uri("http://pw-edit.googlecode.com/svn/trunk/PW Edit/PWEditTesting/npcgen2.data"), temp + "npcgen2.data");
                    }
                    break;
                }
            }
            while (true)
            {
                if (!wc.IsBusy)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    break;
                }
            }
            #endregion
            NPCGEN npcgen = new NPCGEN(temp + "npcgen.data");
            npcgen.ToXml(temp + "npcgen.xml");
            npcgen.Save(temp + "2npcgen.data");
            Trigger test = new Trigger();
            test.name = "test";
            test.id = 9001;
            npcgen.triggers.Add(test);
            npcgen.ToXml(temp + "2npcgen.xml");
            npcgen.Save(temp + "3npcgen.data");
            npcgen = new NPCGEN(temp + "npcgen2.data");
            npcgen.ToXml(temp + "2npcgen2.xml");
            npcgen.Save(temp + "2npcgen2.data");
            //CD-EA-C3-C0
            Console.WriteLine(BitConverter.ToString(Encoding.GetEncoding("GB2312").GetBytes("完美")));
            //8C-5B-8E-7F (FF-FE-8C-5B-8E-7F if a BOM is included)
            Console.WriteLine(BitConverter.ToString(Encoding.GetEncoding("UTF-16LE").GetBytes("完美")));
            foreach(EncodingInfo a in Encoding.GetEncodings())
            {
                Console.WriteLine(a.Name);
            }
            Trigger testTrigger = new Trigger();
            testTrigger.name = "Test";
            Console.WriteLine(testTrigger.name);
            Console.ReadKey(true);
        }

        #region hideme2
        //static ProgressBar.ProgressBar progress;
        static void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            //drawTextProgressBar(e.ProgressPercentage, 100);
            //progress.Update(e.ProgressPercentage);
            Console.Write(".");
        }
        #endregion
    }
}
