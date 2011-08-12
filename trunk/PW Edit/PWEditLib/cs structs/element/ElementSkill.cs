using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PWEditLib.ElementsData
{
    enum ElementSkill
    {
        PDefP500 = 220,
        MaxEndP200 = 300,
        ReqM10,
        ReqM20,
        ReqM30,
        ReqM40,
        ReqM50,
        MagResP250,
        MagResP500,
        MagResP750,
        MagResP1000,
        MagResP1500,
        ReducePDamage1,
        ReducePDamage2,
        ReducePDamage3,
        ReducePDamage4,
        ReducePDamage5,
        PDefP8,
        PDefP36,
        /// <summary>
        /// Exactly duplicate of PDefP36
        /// </summary>
        PDefP36N2,
        PDefP58,
        PDefP86,
        HPRecovP3,
        HPRecovP5,
        HPRecovP7,
        HPRecovP10,
        HPRecovP20,
        MPRecovP2,
        MPRecovP3,
        MPRecovP4,
        MPRecovP6,
        MPRecovP10,
        IntBtwAtkM005,
        CastM3,
        CastM6,
        CastM10,
        CastM15,
        IntBtwAtkM01 = 337,
        IntBtwAtkM02,
        CritP1 = 356,
        CritP2,
        /// <summary>
        /// Only works on armor
        /// </summary>
        CritP3,
        /// <summary>
        /// Accessory Only, Don't use on Armor
        /// </summary>
        PDefP60,
        /// <summary>
        /// Accessory Only, Don't use on Armor
        /// </summary>
        PDefP150,
        /// <summary>
        /// Accessory Only, Don't use on Armor
        /// </summary>
        PDefP250,
        ReducePDmgTkn1,
        ReducePDmgTkn2,
        ReducePDmgTkn3,
        MetalResP200,
        EarthResP300 = 378,
        EarthResP500,
        /// <summary>
        /// Accessory Only, Don't use on Armor
        /// </summary>
        MagResP200,
        /// <summary>
        /// Accessory Only, Don't use on Armor
        /// </summary>
        MagResP300,
        /// <summary>
        /// Accessory Only, Don't use on Armor
        /// </summary>
        MagResP500,
        HPRecovP12,
        MPRecovP7,
        /// <summary>
        /// Max HP +5%
        /// </summary>
        MaxHPPP5 = 387,
        /// <summary>
        /// Max MP +5%
        /// </summary>
        MaxMPPP5,
        /// <summary>
        /// Accuracy +10%
        /// </summary>
        AccPP10,
        /// <summary>
        /// Accuracy +30%
        /// </summary>
        AccPP30,
        /// <summary>
        /// Accuracy +50%
        /// </summary>
        AccPP50,
        /// <summary>
        /// Evasion +10%
        /// </summary>
        EvadPP10,
        /// <summary>
        /// Evasion +30%
        /// </summary>
        EvadPP30,
        EXP1 = 404,
        EXP2,
        EXP5,
        MaxEndP25,
        MaxEndP50,
        MaxEndP75,
        IntBtwAtkM005N2 = 420,
        IntBtwAtkM01N2,
        MaxMagAtkP250 = 423,
        ChanM3 = 441,
        ChanM6,
        ChanM10,
        /// <summary>
        /// Rip: Has a chance to cause 5000 bleeding damage over 15 seconds
        /// </summary>
        Rip = 445,
        /// <summary>
        /// Soul Corrode: A Certain Chance to reduce the opponent`s HP Upper Limit
        /// </summary>
        SoulCorrode,
        /// <summary>
        /// Soul Shatter: Has a chance to dispel opponent's positive buffs
        /// </summary>
        SoulShatter = 449,
        AccPP10N2 = 462,
        AccPP30N2 = 464,
        RangeP1 = 471,
        /// <summary>
        /// Works on tomes
        /// </summary>
        CritP1N2 = 473,
        CritP2N2,
        CritP3N2,
        MoveSpeedP01 = 636,
        MoveSpeedP02,
        MoveSpeedP03,
        MoveSpeedP1,
        /// <summary>
        /// +1.5 not 15
        /// </summary>
        MoveSpeedP15,
        EvadP150,
        EvadP250,
        EvadP350,
        EvadP450,
        EvadP600,
        PDefP94 = 656,
        /// <summary>
        /// Armor only
        /// </summary>
        PDefP216 = 661,
        EvadP600N2,
        PhysAtkP56 = 762,
        PhyAtkP63,
        MaxPhysAtkP139 = 805,
        MagAtkP63 = 821,
        MaxMagAtkP94 = 831,
        PhysAtkP24 = 860,
        MagAtkP24 = 893,
        PDefP81 = 918,
        PDefP91,
        EvadP72 = 927,
        EvadP83,
        EvadP93,
        MaxMagAtkP142 = 987,
        MaxMagAtkP130 = 988,
        MagAtkP70 = 990,
        MaxPhysAtackP201 = 998,
        MaxPhysAtkP185,
        MaxPhysAtkP154 = 1001,
        MaxPhysAtkP118 = 1003,
        MaxPhysAtkP130,
        MaxPhysAtkP142,
        PhysAtkP70 = 1009,
        PhysAtkP31 = 1011,
        MagAtkP31 = 1018,
        MagAtkP35,
        PDefP289 = 1056,
        /// <summary>
        /// Strength + 2~3
        /// </summary>
        StrP23 = 1085,
        /// <summary>
        /// Strenth + 3~4
        /// </summary>
        StrP34,
        /// <summary>
        /// Strenth + 4~5
        /// </summary>
        StrP45,
        /// <summary>
        /// Dexterity + 2~3
        /// </summary>
        DexP23 = 1090,
        /// <summary>
        /// Dexterity + 3~4
        /// </summary>
        DexP34,
        /// <summary>
        /// Magic + 2~3
        /// </summary>
        MagP23 = 1095,
        /// <summary>
        /// Magic + 3~4
        /// </summary>
        MagP34,
        /// <summary>
        /// Vitality + 2~3
        /// </summary>
        VitP23 = 1101,
        /// <summary>
        /// Vitality + 3~4
        /// </summary>
        VitP34,
        /// <summary>
        /// Vitality + 4~5
        /// </summary>
        VitP45,
        /// <summary>
        /// Strenth + 8~9
        /// </summary>
        StrP89 = 1108,
        /// <summary>
        /// Dexterity + 8~9
        /// </summary>
        DexP89 = 1113,
        /// <summary>
        /// Vitality + 8~9
        /// </summary>
        VitP89 = 1118,
        /// <summary>
        /// Magic + 8~9
        /// </summary>
        MagP89 = 1123,
        /// <summary>
        /// Strenth +2
        /// </summary>
        StrP2 = 1126,
        /// <summary>
        /// Dexterity + 2~3
        /// </summary>
        DexP23 = 1132,
        /// <summary>
        /// Magic + 2~3
        /// </summary>
        MagP23 = 1136,


    }
}
