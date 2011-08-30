using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Diagnostics;

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
        public Int32 unknown7;
        /// <summary>
        /// Possibly maxnum
        /// </summary>
        public Int32 unknown8;
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
        public Byte unknown5a;
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
        public Int32 triggerID;
        /// <summary>
        /// Byte used instead of Unsigned Char
        /// </summary>
        public Byte scale;
    }
    public class Trigger
    {
        public Int32 id;
        public Int32 gmID;
        /// <summary>
        /// Set as byte array instead of String due to constant size limit
        /// </summary>
        public Byte[] name;
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
            Load(NPCGenFile);
        }
        /// <summary>
        /// Load an npcgen.data file
        /// </summary>
        /// <param name="NPCGenFile">Path to the npcgen.data file</param>
        /// <returns>True on successful load</returns>
        public Boolean Load(String NPCGenFile)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                FileStream fs = new FileStream(NPCGenFile, FileMode.Open);
                //Clone the FileStream into memory release and reset Position on MemoryStream
                fs.CopyTo(ms); fs.Close(); ms.Position = 0;
                BinaryReader br = new BinaryReader(ms);
                creatureSets = new List<CreatureSet>();
                resourceSets = new List<ResourceSet>();
                dynamics = new List<DynamicObj>();
                triggers = new List<Trigger>();
                version = br.ReadInt32();
                creatureSetsCount = br.ReadInt32();
                resourceSetsCount = br.ReadInt32();
                dynamicsCount = br.ReadInt32();
                triggersCount = br.ReadInt32();
                Int32 i;
                Int32 x;
                CreatureSet creatureFillHolder;
                CreatureGroup creatureGFillHolder;
                for (i = 0; i < creatureSetsCount; i++)
                {
                    creatureFillHolder = new CreatureSet();
                    creatureFillHolder.spawnMode = br.ReadInt32();
                    creatureFillHolder.creatureGroupCount = br.ReadInt32();
                    creatureFillHolder.spawnX = br.ReadSingle();
                    creatureFillHolder.spawnY = br.ReadSingle();
                    creatureFillHolder.spawnZ = br.ReadSingle();
                    creatureFillHolder.rot1 = br.ReadSingle();
                    creatureFillHolder.rot2 = br.ReadSingle();
                    creatureFillHolder.rot3 = br.ReadSingle();
                    creatureFillHolder.spreadX = br.ReadSingle();
                    creatureFillHolder.spreadY = br.ReadSingle();
                    creatureFillHolder.spreadZ = br.ReadSingle();
                    creatureFillHolder.unknown1 = br.ReadInt32();
                    creatureFillHolder.unknown2 = br.ReadInt32();
                    creatureFillHolder.unknown3 = br.ReadBoolean();
                    creatureFillHolder.unknown4 = br.ReadBoolean();
                    creatureFillHolder.unknown5 = br.ReadBoolean();
                    creatureFillHolder.unknown6 = br.ReadInt32();
                    creatureFillHolder.trigger = br.ReadInt32();
                    creatureFillHolder.unknown7 = br.ReadInt32();
                    creatureFillHolder.unknown8 = br.ReadInt32();
                    creatureFillHolder.creatureGroups = new List<CreatureGroup>();
                    for (x = 0; x < creatureFillHolder.creatureGroupCount; x++)
                    {
                        creatureGFillHolder = new CreatureGroup();
                        creatureGFillHolder.id = br.ReadInt32();
                        creatureGFillHolder.amount = br.ReadInt32();
                        creatureGFillHolder.respawn = br.ReadInt32();
                        creatureGFillHolder.diedTimes = br.ReadInt32();
                        creatureGFillHolder.agressive = br.ReadInt32();
                        creatureGFillHolder.offsetWater = br.ReadInt32();
                        creatureGFillHolder.offsetTrn = br.ReadInt32();
                        creatureGFillHolder.faction = br.ReadInt32();
                        creatureGFillHolder.facHelper = br.ReadInt32();
                        creatureGFillHolder.facAccept = br.ReadInt32();
                        creatureGFillHolder.needHelp = br.ReadBoolean();
                        creatureGFillHolder.defFaction = br.ReadBoolean();
                        creatureGFillHolder.defFacHelper = br.ReadBoolean();
                        creatureGFillHolder.defFacAccept = br.ReadBoolean();
                        creatureGFillHolder.pathID = br.ReadInt32();
                        creatureGFillHolder.loopType = br.ReadInt32();
                        creatureGFillHolder.speedFlag = br.ReadInt32();
                        creatureGFillHolder.deadTime = br.ReadInt32();
                        creatureFillHolder.creatureGroups.Add(creatureGFillHolder);
                    }
                    creatureSets.Add(creatureFillHolder);
                }
                ResourceSet resourceFillHolder;
                ResourceGroup resourceGFillHolder;
                for (i = 0; i < resourceSetsCount; i++)
                {
                    resourceFillHolder = new ResourceSet();
                    resourceFillHolder.spawnX = br.ReadSingle();
                    resourceFillHolder.spawnY = br.ReadSingle();
                    resourceFillHolder.spawnZ = br.ReadSingle();
                    resourceFillHolder.spreadX = br.ReadSingle();
                    resourceFillHolder.spreadZ = br.ReadSingle();
                    resourceFillHolder.resourceGroupCount = br.ReadInt32();
                    resourceFillHolder.unknown1 = br.ReadBoolean();
                    resourceFillHolder.unknown2 = br.ReadBoolean();
                    resourceFillHolder.unknown3 = br.ReadBoolean();
                    resourceFillHolder.unknown4 = br.ReadInt32();
                    resourceFillHolder.unknown5a = br.ReadByte();
                    resourceFillHolder.unknown5b = br.ReadByte();
                    resourceFillHolder.unknown5c = br.ReadByte();
                    resourceFillHolder.unknownTrigger = br.ReadInt32();
                    resourceFillHolder.unknown6 = br.ReadByte();
                    resourceFillHolder.unknown7 = br.ReadBoolean();
                    resourceFillHolder.unknown8 = br.ReadBoolean();
                    resourceFillHolder.unknown9 = br.ReadBoolean();
                    resourceFillHolder.resourceGroups = new List<ResourceGroup>();
                    for (x = 0; x < resourceFillHolder.resourceGroupCount; x++)
                    {
                        resourceGFillHolder = new ResourceGroup();
                        resourceGFillHolder.type = br.ReadInt32();
                        resourceGFillHolder.id = br.ReadInt32();
                        resourceGFillHolder.respawn = br.ReadInt32();
                        resourceGFillHolder.amount = br.ReadInt32();
                        resourceGFillHolder.unknown1 = br.ReadInt32();
                        resourceFillHolder.resourceGroups.Add(resourceGFillHolder);
                    }
                    resourceSets.Add(resourceFillHolder);
                }
                DynamicObj dynamicObjFillHolder;
                for (i = 0; i < dynamicsCount; i++)
                {
                    dynamicObjFillHolder = new DynamicObj();
                    dynamicObjFillHolder.id = br.ReadInt32();
                    dynamicObjFillHolder.spawnX = br.ReadSingle();
                    dynamicObjFillHolder.spawnY = br.ReadSingle();
                    dynamicObjFillHolder.spawnZ = br.ReadSingle();
                    dynamicObjFillHolder.dir1 = br.ReadByte();
                    dynamicObjFillHolder.dir2 = br.ReadByte();
                    dynamicObjFillHolder.rad = br.ReadByte();
                    dynamicObjFillHolder.triggerID = br.ReadInt32();
                    dynamicObjFillHolder.scale = br.ReadByte();
                    dynamics.Add(dynamicObjFillHolder);
                }
                Trigger triggerFillHolder;
                for (i = 0; i < triggersCount; i++)
                {
                    triggerFillHolder = new Trigger();
                    triggerFillHolder.id = br.ReadInt32();
                    triggerFillHolder.gmID = br.ReadInt32();
                    //name is ALWAYS 128 bytes long
                    triggerFillHolder.name = br.ReadBytes(128);
                    triggerFillHolder.autostart = br.ReadBoolean();
                    triggerFillHolder.autostartDelay = br.ReadInt32();
                    triggerFillHolder.autostopDelay = br.ReadInt32();
                    triggerFillHolder.dontStartOnSch = br.ReadBoolean();
                    triggerFillHolder.dontStoponSch = br.ReadBoolean();
                    triggerFillHolder.year1 = br.ReadInt32();
                    triggerFillHolder.month1 = br.ReadInt32();
                    triggerFillHolder.weekDay1 = br.ReadInt32();
                    triggerFillHolder.day1 = br.ReadInt32();
                    //no idea why they didn't use byte here... 
                    //not like there are 256 hours in a day...
                    //and for month/weekday/day
                    triggerFillHolder.hour1 = br.ReadInt32();
                    //same for this
                    triggerFillHolder.minute1 = br.ReadInt32();
                    triggerFillHolder.year2 = br.ReadInt32();
                    triggerFillHolder.month2 = br.ReadInt32();
                    triggerFillHolder.weekDay2 = br.ReadInt32();
                    triggerFillHolder.day2 = br.ReadInt32();
                    triggerFillHolder.hour2 = br.ReadInt32();
                    triggerFillHolder.minute2 = br.ReadInt32();
                    triggerFillHolder.duration = br.ReadInt32();
                    triggers.Add(triggerFillHolder);
                }
                    return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return false;
            }
        }
        /// <summary>
        /// Load an NPCGEN object from an XML file
        /// </summary>
        /// <param name="XMLNPCGenData">Path to XML file containing NPCGen</param>
        /// <returns>New NPCGEN object</returns>
        public NPCGEN LoadFromXml(String XMLNPCGenData)
        {
            StreamReader sr = new StreamReader(@XMLNPCGenData);
            return LoadFromXmlString(sr.ReadToEnd());
        }
        /// <summary>
        /// Load an NPCGEN object from an XML string
        /// </summary>
        /// <param name="XMLNPCGenData">XML String containing NPCGen</param>
        /// <returns>New NPCGEN object</returns>
        public NPCGEN LoadFromXmlString(String XMLNPCGenData)
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(NPCGEN));
                MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(XMLNPCGenData));
                return xs.Deserialize(ms) as NPCGEN;
            }
            catch (Exception e)
            {
                Debug.Write(e.Message);
                return new NPCGEN();
            }
        }
        /// <summary>
        /// Save an npcgen.data file
        /// </summary>
        /// <param name="NPCGenFile">Path to save npcgen.data to</param>
        /// <returns>True on successful save</returns>
        public Boolean Save(String NPCGenFile)
        {
            return true;
        }
        /// <summary>
        /// Serialize npcgen.data to XML
        /// </summary>
        /// <param name="fileName">Filename to save to</param>
        public void ToXml(String fileName)
        {
            //XmlSerializer serialize = new XmlSerializer(typeof(NPCGEN));
            TextWriter tw = new StreamWriter(@fileName);
            tw.Write(ToXml());
            //serialize.Serialize(tw, this);
            tw.Close();
        }
        /// <summary>
        /// Serialize npcgen.data to XML
        /// </summary>
        /// <returns>XML Formatted String of npcgen.data</returns>
        public String ToXml()
        {
            XmlSerializer serialize = new XmlSerializer(typeof(NPCGEN));
            MemoryStream ms = new MemoryStream();
            serialize.Serialize(ms, this);
            return Encoding.UTF8.GetString(ms.ToArray());
        }
    }
}

