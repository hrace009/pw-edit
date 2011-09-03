using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PWEditLib.NPCGenData;
using System.IO;

namespace PWEditTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            String temp = Path.GetTempPath() + "{6294C1D2-CD9C-4F86-B80C-686B45217497}";
            if (!Directory.Exists(temp))
            {
                Directory.CreateDirectory(temp);
            }
            temp += "\\";
            NPCGEN npcgen = new NPCGEN(temp + "npcgen.data");
            npcgen.ToXml(temp + "npcgen.xml");
            npcgen.Save(temp + "npcgen2.data");
            npcgen = new NPCGEN(temp + "npcgen2.data");
            npcgen.ToXml(temp + "2npcgen.xml");
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
            Console.ReadKey(false);
        }
    }
}
