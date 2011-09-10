using System;
using System.Text;
using System.Runtime.InteropServices;

namespace PWEditLib.ElementsData.Client.V136
{
    /// <summary>
    /// List 1
    /// </summary>
    public class EquipmentAddon
    {
        public UInt32 id;
        public String name;
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
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst=32)]
        public String name;
    }
    /// <summary>
    /// List 3
    /// </summary>
    public class WeaponSubType
    {
        public UInt32 id;
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst=32)]
        public String name;
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 128)]
        public String hitgfx;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public String hitsfx;


    }
}
