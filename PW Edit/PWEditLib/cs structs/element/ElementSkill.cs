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


    }
}
