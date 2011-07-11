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

    }
}
