using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RimWorld;
using AlienRace;
using Verse;

namespace Necromancy
{
    public static class Races
    {
        static Races()
        {
            RaceProps = ThingDefOf.Human.race;
            RaceProps.intelligence = Intelligence.ToolUser;
            RaceProps.lifeExpectancy = 85f;
            RaceProps.foodType = FoodTypeFlags.None;
            RaceProps.gestationPeriodDays = 0;
            RaceProps.litterSizeCurve = null;
            RaceProps.lifeStageAges = new List<LifeStageAge>()
            {
                new LifeStageAge()
                {
                    def = UndeadProps.DecompositionStagesDef[0],
                    minAge = 0,
                    
                }
            };
        }

        public static RaceProperties RaceProps = null;

        public static HairDef Hair = new HairDef()
        {
        };

        public static PawnKindSettings PawnKindSettings = new PawnKindSettings()
        {
            alienwandererkinds = new List<FactionPawnKindEntry>()
            {
                new FactionPawnKindEntry()
                {
                    pawnKindEntries = new List<PawnKindEntry>()
                    {
                        new PawnKindEntry()
                        {
                            kindDefs = new List<string>()
                            {

                            }
                        }
                    }
                }
            }
        };

        public static ThingDef_AlienRace BaseUndead = new ThingDef_AlienRace()
        {
            defName = "Undead",
            label = "undead",
            description = "An unnatural but mindless construct, obeying whoever created them without question nor thought.",
            alienRace = new ThingDef_AlienRace.AlienSettings()
            {
                generalSettings = new GeneralSettings()
                {
                    immuneToAge = true,
                    forcedRaceTraitEntries = new List<AlienTraitEntry>()
                    {
                        new AlienTraitEntry()
                        {
                            defName = "Nerves",
                            degree = 2,
                            chance = 1f
                        },

                        new AlienTraitEntry()
                        {
                            defName = "DrugDesire",
                            degree = 2,
                            chance = 0f
                        },
                        new AlienTraitEntry()
                        {
                            defName = "DrugDesire",
                            degree = 1,
                            chance = 0f
                        },
                        new AlienTraitEntry()
                        {
                            defName = "PsychicSensitivity",
                            degree = -2,
                            chance = 1f
                        },
                        new AlienTraitEntry()
                        {
                            defName = "Psychopath",
                            chance = 1f
                        }
                    },
                    disallowedTraits = new List<string>()
                    {
                        "CreepyBreathing",
                        "FastLearner",
                        "Gay",
                        "GreenThumb",
                        "Masochist",
                        "Nudist",
                        "Prosthophile",
                        "Prosthophobe",
                        "SuperImmune",
                        "Wimp",
                        
                        "NaturalMood",
                        "Neurotic"
                    },
                    alienPartGenerator = new AlienPartGenerator()
                    {
                        useGenderedHeads = true,
                        useGenderedBodies = false
                    }
                },
                thoughtSettings = new ThoughtSettings()
                {
                    cannotReceiveThoughts = new List<string>()
                    {
                        "MySonDied",
                        "MyDaughterDied",
                        "MyHusbandDied",
                        "MyWifeDied",
                        "MyFianceDied",
                        "MyFianceeDied",
                        "MyBrotherDied",
                        "MySisterDied",
                        "MyGrandchildDied",
                        "MyFatherDied",
                        "MyMotherDied",
                        "MyNieceDied",
                        "MyNephewDied",
                        "MyHalfSiblingDied",
                        "MyAuntDied",
                        "MyUncleDied",
                        "MyGrandparentDied",
                        "MyCousinDied",
                        "MyKinDied",

                        "Pain",
                        "NeedRest",
                        "NeedFood",
                        "NeedBeauty",
                        "NeedSpace",
                        "Naked",

                        "WakeUpHigh",
                        "SmokeleafHigh",
                        "FlakeHigh",
                        "YayoHigh",
                        "GoJuiceHigh",
                        "Hangover",
                        "Inebriated",
                        "Hungover",
                        "AlcoholWithdrawal",
                        "Joywire",
                        "Aurora",

                        "AteLavishMeal",
                        "AteFineMeal",
                        "AteAwfulMeal",
                        "AteRawFood",
                        "AteKibble",
                        "AteCorpse",
                        "AteHumanlikeMeatDirect",
                        "AteHumanlikeMeatAsIngredient",
                        "AteInsectMeatDirect",
                        "AteInsectMeatAsIngredient",
                        "AteRottenFood",

                        "FeelingRandom",

                        "KindWords",
                        "KindWordsMood",
                        "HadCatharticFight",
                        "CrashedTogether",
                        "FailedRomanceAttemptOnMe",
                        "FailedRomanceAttemptOnMeLowOpinionMood",
                        "IRejectedTheirProposal",
                        "HoneymoonPhase",
                        "KilledMyRival",
                        "Incestuous",
                        "Disfigured",
                        "ChemicalInterestVsTeetotaler",
                        "Pretty",
                        "Ugly",
                        "AteRawHumanlikeMeat",
                        "SoldPrisoner",
                        "ExecutedPrisoner",
                        "KilledMajorColonyEnemy",
                        "OpinionOfMyLover",
                        "BondedAnimalMaster",
                        "GotMarried",
                        "AttendedWedding",
                        "AttendedParty",

                        "AteWithoutTable",
                        "SleepDisturbed",
                        "NewColonyOptimism",
                        "NewColonyHope",
                        "SleptOutside",
                        "SleptOnGround",
                        "SleptInCold",
                        "MyOrganHarvested",
                        "GreenThumbHappy",
                        "Catharsis",
                        "KnowBuriedInSarcophagus",
                        "ObservedLayingRottingCorpse",
                        "FailedToRescueRelative",
                        "RescuedRelative",

                        "LowExpectations",
                        "CabinFever",
                        "ApparelDamaged",
                        "DeadMansApparel",
                        "HumanLeatherApparelSad",
                        "Sick",
                        "EnvironmentCold",
                    }
                },
                relationSettings = new RelationSettings()
                {
                    // Depending on how long they were dead, it is likely that a lot of people they knew passed away.
                    relationChanceModifierLover = 0.25f,
                    relationChanceModifierExLover = 0.25f,
                    relationChanceModifierFiance = 0.1f,
                    relationChanceModifierSpouse = 0.05f,
                    relationChanceModifierChild = 0.25f,
                    relationChanceModifierExSpouse = 0.25f,
                    relationChanceModifierParent = 0.1f,
                    relationChanceModifierSibling = 0.25f,
                    renamer = new List<RelationRenamer>()
                    {
                        new RelationRenamer()
                        {
                            relation = "Lover",
                            label = "NecrophiliaPartner",
                            femaleLabel = "NecrophiliaPartner"
                        }
                    }
                }
            },
            statBases = new List<StatModifier>()
            {
                new StatModifier()
                {
                    stat = StatDefOf.MarketValue,
                    value = 300f
                },
                new StatModifier()
                {
                    stat = StatDefOf.Flammability,
                    value = 1.0f
                },
                new StatModifier()
                {
                    stat = StatDefOf.ComfyTemperatureMin,
                    value = 4
                },
                new StatModifier()
                {
                    stat = StatDefOf.ComfyTemperatureMax,
                    value = 36
                },
                new StatModifier()
                {
                    stat = StatDefOf.LeatherAmount,
                    value = 22
                }
            },
            race = new RaceProperties()
            {
                intelligence = Intelligence.ToolUser,
                makesFootprints = true,
                lifeExpectancy = 85f
            }
        };
    }
}
