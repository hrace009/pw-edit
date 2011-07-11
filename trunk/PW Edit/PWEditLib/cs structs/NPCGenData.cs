using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PWEditLib.NPCGenData
{
    public class CreatureGroup
    {
        Int32 id;
        Int32 amount;
        Int32 respawn;
        //All of the unknowns (from Ronny1982's npcgen.h) are taken from screenshots
        //http://forum.ragezone.com/f452/demo-npcgen-edit-762857/
        Int32 diedTimes;
        Int32 agressive;
        Int32 offsetWater;
        Int32 offsetTrn;
        Int32 faction;
        Int32 facHelper;
        Int32 facAccept;
        Boolean needHelp;
        Boolean defFaction;
        Boolean defFacHelper;
        Boolean defFacAccept;
        Int32 pathID;
        Int32 loopType;
        Int32 speedFlag;
        Int32 deadTime;
    }
    public class CreatureSet
    {
        Int32 spawnMode;
        Int32 creatureGroupCount;
        Single spawnX;
        Single spawnY;
        Single spawnZ;
        Single rot1;
        Single rot2;
        Single rot3;
        Single spreadX;
        Single spreadY;
        Single spreadZ;
        /// <summary>
        /// Possibly Mob/NPC toggle
        /// </summary>
        Int32 unknown1;
        Int32 unknown2;
        Boolean unknown3;
        Boolean unknown4;
        /// <summary>
        /// Possibly instant respawn toggle
        /// </summary>
        Boolean unknown5;
        Int32 unknown6;
        Int32 trigger;
        /// <summary>
        /// Possibly lifetime
        /// </summary>
        Int32 unknown6;
        /// <summary>
        /// Possibly maxnum
        /// </summary>
        Int32 unknown7;
        List<CreatureGroup> creatureGroups;
    }
    public class ResourceGroup
    {
        Int32 type;
        Int32 id;
        Int32 respawn;
        Int32 amount;
        Int32 unknown1;
    }
    public class ResourceSet
    {
        Single spawnX;
        Single spawnY;
        Single spawnZ;
        Single spreadX;
        Single spreadZ;
        Int32 resourceGroupCount;
        Boolean unknown1;
        Boolean unknown2;
        Boolean unknown3;
        Int32 unknown4;
        /// <summary>
        /// Byte used instead of Unsigned Char
        /// </summary>
        Byte unknow5a;
        /// <summary>
        /// Byte used instead of Unsigned Char
        /// </summary>
        Byte unknown5b;
        /// <summary>
        /// Byte used instead of Unsigned Char
        /// </summary>
        Byte unknown5c;
        Int32 unknownTrigger;
        /// <summary>
        /// Byte used instead of Unsigned Char
        /// </summary>
        Byte unknown6;
        Boolean unknown7;
        Boolean unknown8;
        Boolean unknown9;
        List<ResourceGroup> resourceGroups;
    }
    public class DynamicObj
    {
        Int32 id;
        Single spawnX;
        Single spawnY;
        Single spawnZ;
        /// <summary>
        /// Byte used instead of Unsigned Char
        /// </summary>
        Byte dir1;
        /// <summary>
        /// Byte used instead of Unsigned Char
        /// </summary>
        Byte dir2;
        /// <summary>
        /// Byte used instead of Unsigned Char
        /// </summary>
        Byte rad;
        Trigger trigger;
        /// <summary>
        /// Byte used instead of Unsigned Char
        /// </summary>
        Byte scale;

    }
    public class Trigger
    {
        Int32 id;
        Int32 gmID;
        String name;
        Boolean autostart;
        Int32 autostartDelay;
        Int32 autostopDelay;
        Boolean dontStartOnSch;
        Boolean dontStoponSch;
        Int32 year1;
        Int32 month1;
        Int32 weekDay1;
        Int32 day1;
        Int32 hour1;
        Int32 minute1;
        Int32 year2;
        Int32 month2;
        Int32 weekDay2;
        Int32 day2;
        Int32 hour2;
        Int32 minute2;
        Int32 duration;
    }
    public class NPCGEN
    {
        Int32 version;
        Int32 creatureSetsCount;
        Int32 resourceSetsCount;
        Int32 dynamicsCount;
        Int32 triggersCount;
        List<CreatureSet> creatureSets;
        List<ResourceSet> resourceSets;
        List<DynamicObj> dynamics;
        List<Trigger> triggers;
    }
}

