namespace PWEditLib.ElementsData
{
    public enum ElementSkill
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
        MagResP500N2,
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
        DexP23N2 = 1132,
        /// <summary>
        /// Magic + 2~3
        /// </summary>
        MagP23N2 = 1136,
        PDefP45 = 1246,
        PDefP69,
        PDefP94N2,
        PDefP118,
        PDefP142,
        PDefP167,
        PDefP191,
        PDefP216N2,
        PDefP240,
        PDefP264,
        PDefP289N2,
        PdefP313,
        EvadP10,
        EvadP26,
        EvadP46,
        EvadP70,
        EvadP94,
        EvadP118,
        EvadP142,
        EvadP262 = 1269,
        EvadP286,
        EvadP310,
        ReducePDmgTkn1N2,
        ReducePDmgTkn2N2,
        ReducePDmgTkn3N2,
        /// <summary>
        /// Pierce: Has a chance to decrease opponent's physical defence
        /// </summary>
        Pierce,
        /// <summary>
        /// Distract: Has a chance to decrease opponent's magic defence
        /// </summary>
        Distract,
        /// <summary>
        /// Fright: has a chance to decrease target's physical attack
        /// </summary>
        Fright,
        /// <summary>
        /// Muddle: has a chance to decrease target's magic attack
        /// </summary>
        Muddle,
        /// <summary>
        /// Atrophy: has a chance to decrease target's attack rate
        /// </summary>
        Atrophy,
        /// <summary>
        /// Stupefy: Has a chance to slow target's channeling
        /// </summary>
        Stupefy,
        /// <summary>
        /// Blind: Has a chance to decrease opponent's accuracy
        /// </summary>
        Blind,
        /// <summary>
        /// Daze: Has a chance to decrease enemy's evasion
        /// </summary>
        Daze,
        /// <summary>
        /// Toughen: Has a chance to increase physical defence
        /// </summary>
        Toughen,
        /// <summary>
        /// Wisen: Has a chance to increase character's magic defence
        /// </summary>
        Wisen,
        /// <summary>
        /// Slow: Has a chance to slow the opponent
        /// </summary>
        Slow,
        /// <summary>
        /// Sharpen: Has a chance to increase physical attack
        /// </summary>
        Sharpen,
        /// <summary>
        /// Quicken: Has a chance to increase attack rate
        /// </summary>
        Quicken,
        /// <summary>
        /// Nimble: Has a chance to increase accuracy
        /// </summary>
        Nimble,
        /// <summary>
        /// Regeneration: Has a chance to recover 5% HP
        /// </summary>
        Regeneration,
        /// <summary>
        /// Enlighten: Has a chance to recover MP by 5%
        /// </summary>
        Enlighten,
        /// <summary>
        /// Gloom: Has a chance to greatly increase physical attack at the cost of losing 5% MP
        /// </summary>
        Gloom,
        /// <summary>
        /// Unrelenting: Has a chance to greatly increase physical attack at the cost of reducing physical defence
        /// </summary>
        Unrelenting,
        /// <summary>
        /// Provoke: Increase your threat level
        /// </summary>
        Provoke,
        /// <summary>
        /// Has a chance to stun target for 3 seconds
        /// </summary>
        Stun3Sec,
        /// <summary>
        /// Freeze: Has a chance to freeze the opponent for 3 seconds
        /// </summary>
        Freeze,
        /// <summary>
        /// Seal: Has a chance to make the target unable to attack for 5 seconds
        /// </summary>
        Seal,
        /// <summary>
        /// Sacrificial Strike: Has a chance to inflict double damage at the cost of losing 5% HP
        /// </summary>
        SacrificialStrike,
        /// <summary>
        /// Berserk: Has a chance to make the wielder go berserk, increasing physical attack and attack rate along with damage taken
        /// </summary>
        Berserk,
        /// <summary>
        /// Meditation: Has a chance to recover HP and MP both by 5%
        /// </summary>
        Meditation,
        /// <summary>
        /// Blood Defect: Has a chance to recover 10% HP
        /// </summary>
        BloodDefect,
        /// <summary>
        /// Spirit Defect: Has a chance to recover 10% MP
        /// </summary>
        SpiritDefect,
        /// <summary>
        /// Revenge: Has a chance to recover 5% HP, and increase physical attack
        /// </summary>
        Revenge,
        /// <summary>
        /// Comprehend: Has a chance to increase MP by 5% and increase physical attack
        /// </summary>
        Comprehend,
        /// <summary>
        /// Spikes: Has a chance to increase physical defence as well as return 25% melee damage to attacker
        /// </summary>
        Spikes,
        /// <summary>
        /// Shield of Chi: Has a chance to cast a shield of Chi around you which reduces all damage taken by 20%
        /// </summary>
        ShieldOfChi,
        /// <summary>
        /// Bless: Has a chance to increase Physical Attack and Physical Defense
        /// </summary>
        Bless,
        /// <summary>
        /// Faith: Has a chance to recover 5% HP and increase both physical defence and magic defence
        /// </summary>
        Faith,
        /// <summary>
        /// Determination: Has a chance to stun opponent for 5 seconds but also freeze yourself for 10 seconds
        /// </summary>
        Determination,
        /// <summary>
        /// Holy: Has a chance to recover HP by 5%, and remove all debuffs
        /// </summary>
        Holy,
        /// <summary>
        /// Darken: Has a chance to freeze and seal the enemy
        /// </summary>
        Darken,
        AccP8,
        AccP22,
        AccP38,
        AccP58,
        AccP78,
        AccP98,
        AccP118,
        AccP138,
        AccP158,
        AccP178,
        AccP198,
        AccP218,
        AccP238,
        AccP258,
        MPP310 = 1332,
        HPP205 = 1340,
        HPP225,
        HPP245,
        HPP150 = 1347,
        HPP165,
        HPP180,
        MPP110 = 1360,
        MPP130,
        MPP250 = 1367,
        HPP60 = 1375,
        HPP70,
        HPP80,
        HPP90,
        HPP105,
        HPP150N2 = 1382,
        PhyAtkP100 = 1403,
        PhyAtkP150,
        AccP100 = 1406,
        AccP200,
        AccP300,
        EvadP250N2,
        EvadP500,
        HPP100,
        HPP200,
        HPP350,
        HPP500,
        HPP750,
        HPP1000,
        ChanM20,
        /// <summary>
        /// Dexterity +25
        /// </summary>
        DexP25,
        /// <summary>
        /// Magic +25
        /// </summary>
        MagP25,
        PDefP400,
        CritP4,
        RangeP2,
        MagAtkP25,
        MagAtkP50,
        MagAtkP100,
        MagAtkP150,
        MagAtkP200,
        CanM10,
        /// <summary>
        /// Strength +5~6
        /// </summary>
        StrP56,
        /// <summary>
        /// Strength +7~8
        /// </summary>
        StrP78,
        /// <summary>
        /// Strength +8~9
        /// </summary>
        StrP89N2,
        /// <summary>
        /// Strength +9~10
        /// </summary>
        StrP910,
        /// <summary>
        /// Strength +10~11
        /// </summary>
        StrP1011,
        /// <summary>
        /// Dexterity +5~6
        /// </summary>
        DexP56,
        /// <summary>
        /// Dexterity +7~8
        /// </summary>
        DexP78,
        /// <summary>
        /// Dexterity +8~9
        /// </summary>
        DexP89N2,
        /// <summary>
        /// Dexterity +9~10
        /// </summary>
        DexP910,
        /// <summary>
        /// Magic +4~5
        /// </summary>
        MagP45,
        /// <summary>
        /// Magic +5~6
        /// </summary>
        MagP56,
        /// <summary>
        /// Magic +7~8
        /// </summary>
        MagP78,
        /// <summary>
        /// Magic +8~9
        /// </summary>
        MagP89N2,
        /// <summary>
        /// Magic +9~10
        /// </summary>
        MagP910,
        /// <summary>
        /// Vitality +5~6
        /// </summary>
        VitP56,
        /// <summary>
        /// Vitality +6~7
        /// </summary>
        VitP67,
        /// <summary>
        /// Vitality +7~8
        /// </summary>
        VitP78,
        /// <summary>
        /// Vitality +8~9
        /// </summary>
        VitP89N2,
        /// <summary>
        /// Vitality +9~10
        /// </summary>
        VitP910,
        ChanM15,
        StrP6,
        StrP6N2,
        StrP8,
        StrP9,
        StrP10,
        DexP5,
        DexP7,
        DexP8,
        DexP9,
        DexP10,
        MagP5,
        MagP7,
        MagP8,
        MagP9,
        MagP10,
        VitP6,
        VitP7,
        VitP9,
        VitP10,
        StrP1011N2,
        StrP1213,
        StrP1415,
        StrP1819,
        DexP1011,
        DexP1213,
        DexP1415,
        DexP1617,
        DexP1819,
        MagP1011,
        MagP1213,
        MagP1415,
        MagP1617,
        MagP1819,
        StrP25,
        VitP25,
        StrP40,
        VitP40,
        DexP40,
        MagP40,
        StrP56N2,
        StrP67,
        StrP78N2,
        CritP1N3 = 1510,
        ChanM5,
        AccPP10N3,
        StrP15,
        DexP15,
        VitP20,
        MagP15,
        MetalResP109 = 1538,
        MetalResP125 = 1540,
        WoodResP109 = 1588,
        WoodResP125 = 1590,
        WaterResP109 = 1633,
        WaterResP125
    }
}
