﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace PWEditLib.NPCGenData
{
    public class CreatureGroup
    {
        public Int32 id;
        public Int32 amount;
        public Int32 respawn;
        //All of the unknowns (from Ronny1982's npcgen.h) are taken from screenshots
        //http://forum.ragezone.com/f452/demo-npcgen-edit-762857/
        public Int32 diedTimes;
        public Int32 agressive;
        public Int32 offsetWater;
        public Int32 offsetTrn;
        public Int32 faction;
        public Int32 facHelper;
        public Int32 facAccept;
        public Boolean needHelp;
        public Boolean defFaction;
        public Boolean defFacHelper;
        public Boolean defFacAccept;
        public Int32 pathID;
        public Int32 loopType;
        public Int32 speedFlag;
        public Int32 deadTime;
    }
    public class CreatureSet
    {
        public Int32 spawnMode;
        public Int32 creatureGroupCount;
        public Single spawnX;
        public Single spawnY;
        public Single spawnZ;
        public Single rot1;
        public Single rot2;
        public Single rot3;
        public Single spreadX;
        public Single spreadY;
        public Single spreadZ;
        /// <summary>
        /// Possibly Mob/NPC toggle
        /// </summary>
        public Int32 unknown1;
        public Int32 unknown2;
        public Boolean unknown3;
        public Boolean unknown4;
        /// <summary>
        /// Possibly instant respawn toggle
        /// </summary>
        public Boolean unknown5;
        public Int32 unknown6;
        public Int32 trigger;
        /// <summary>
        /// Possibly lifetime
        /// </summary>
        public Int32 unknown6;
        /// <summary>
        /// Possibly maxnum
        /// </summary>
        public Int32 unknown7;
        public List<CreatureGroup> creatureGroups;
    }
    public class ResourceGroup
    {
        public Int32 type;
        public Int32 id;
        public Int32 respawn;
        public Int32 amount;
        public Int32 unknown1;
    }
    public class ResourceSet
    {
        public Single spawnX;
        public Single spawnY;
        public Single spawnZ;
        public Single spreadX;
        public Single spreadZ;
        public Int32 resourceGroupCount;
        public Boolean unknown1;
        public Boolean unknown2;
        public Boolean unknown3;
        public Int32 unknown4;
        /// <summary>
        /// Byte used instead of Unsigned Char
        /// </summary>
        public Byte unknow5a;
        /// <summary>
        /// Byte used instead of Unsigned Char
        /// </summary>
        public Byte unknown5b;
        /// <summary>
        /// Byte used instead of Unsigned Char
        /// </summary>
        public Byte unknown5c;
        public Int32 unknownTrigger;
        /// <summary>
        /// Byte used instead of Unsigned Char
        /// </summary>
        public Byte unknown6;
        public Boolean unknown7;
        public Boolean unknown8;
        public Boolean unknown9;
        public List<ResourceGroup> resourceGroups;
    }
    public class DynamicObj
    {
        public Int32 id;
        public Single spawnX;
        public Single spawnY;
        public Single spawnZ;
        /// <summary>
        /// Byte used instead of Unsigned Char
        /// </summary>
        public Byte dir1;
        /// <summary>
        /// Byte used instead of Unsigned Char
        /// </summary>
        public Byte dir2;
        /// <summary>
        /// Byte used instead of Unsigned Char
        /// </summary>
        public Byte rad;
        public Trigger trigger;
        /// <summary>
        /// Byte used instead of Unsigned Char
        /// </summary>
        public Byte scale;
    }
    public class Trigger
    {
        public Int32 id;
        public Int32 gmID;
        public String name;
        public Boolean autostart;
        public Int32 autostartDelay;
        public Int32 autostopDelay;
        public Boolean dontStartOnSch;
        public Boolean dontStoponSch;
        public Int32 year1;
        public Int32 month1;
        public Int32 weekDay1;
        public Int32 day1;
        public Int32 hour1;
        public Int32 minute1;
        public Int32 year2;
        public Int32 month2;
        public Int32 weekDay2;
        public Int32 day2;
        public Int32 hour2;
        public Int32 minute2;
        public Int32 duration;
    }
    public class NPCGEN
    {
        public Int32 version;
        public Int32 creatureSetsCount;
        public Int32 resourceSetsCount;
        public Int32 dynamicsCount;
        public Int32 triggersCount;
        public List<CreatureSet> creatureSets;
        public List<ResourceSet> resourceSets;
        public List<DynamicObj> dynamics;
        public List<Trigger> triggers;
        /// <summary>
        /// dummy constructor, manual load/save available
        /// </summary>
        public NPCGEN() { }
        /// <summary>
        /// auto load constructor, manual load/save available
        /// </summary>
        /// <param name="NPCGenFile">Path to the npcgen.data file</param>
        public NPCGEN(String NPCGenFile)
        {

        }
        /// <summary>
        /// Load an npcgen.data file
        /// </summary>
        /// <param name="NPCGenFile">Path to the npcgen.data file</param>
        /// <returns>True on successful load</returns>
        public Boolean load(String NPCGenFile)
        {

        }
        /// <summary>
        /// Save an npcgen.data file
        /// </summary>
        /// <param name="NPCGenFile">Path to save npcgen.data to</param>
        /// <returns>True on successful save</returns>
        public Boolean save(String NPCGenFile)
        {
            return true;
        }
    }
}
