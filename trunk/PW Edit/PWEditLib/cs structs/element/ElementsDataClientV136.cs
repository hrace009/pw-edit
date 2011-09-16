using System;
using System.Text;
using System.Runtime.InteropServices;

namespace PWEditLib.ElementsData.Client.V136
{
    internal class NameHandler
    {
        internal Byte[] fixedName;
        internal String sName;
        public NameHandler(Encoding encoding, String fixFrom, Int32 maxLen)
        {
            fixedName = new Byte[maxLen];
            if (fixFrom != null && !fixFrom.Equals(String.Empty))
            {
                Byte[] temp = encoding.GetBytes(fixFrom);
                if (temp.Length > maxLen)
                {
                    for (Int32 i = 0; i < maxLen; i++)
                    {
                        fixedName[i] = temp[i];
                    }
                }
                else
                {
                    temp.CopyTo(fixedName, 0);
                }
            }
        }
        public NameHandler(Encoding encoding, Byte[] name)
        {
            if (name == null || name[0] == 0)
            {
                sName = "Undefined";
            }
            else
            {
                sName = encoding.GetString(name).TrimEnd('\0');
            }
        }
    }
    /// <summary>
    /// List 1
    /// </summary>
    public class EquipmentAddon
    {
        public UInt32 id;
        Byte[] _name;
        public String name
        {
            get
            {
                return new NameHandler(Encoding.Unicode, _name).sName;
            }
            set
            {
                _name = new NameHandler(Encoding.Unicode, value, 128).fixedName;
            }
        }
        public Int32 num_params;
        public Int32 param1;
        public Int32 param2;
        public Int32 param3;
    }
    /// <summary>
    /// List 2
    /// </summary>
    public class WeaponMajorType
    {
        public Int32 id;
        public String name;
    }
    /// <summary>
    /// List 3
    /// </summary>
    public class WeaponSubType
    {
        public UInt32 id;
        public String name;
        public String hitgfx;
        public String hitsfx;

    }
}
