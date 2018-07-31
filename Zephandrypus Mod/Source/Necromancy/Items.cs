using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using RimWorld;
using RimWorld.BaseGen;
using RimWorld.Planet;
using Verse;
using Verse.AI;
using Verse.AI.Group;
using Verse.Grammar;
using Verse.Noise;
using Verse.Profile;
using Verse.Sound;
using Verse.Steam;

namespace Necromancy
{
    public static class Items
    {
        public static ChemicalDef ElixirOfDefilation = new ChemicalDef()
        {
            canBinge = false,
            defName = "ElixirOfDefilation",
            description = "A vile concoction created for the specific purpose of becoming a lich. Tastes like pure evil.",
            label = "elixir of defilation"
        };

        public static CompDrug LichDrug = new CompDrug()
        {
            parent = new ThingWithComps()
            {
                
            },
            props = new CompProperties_Drug()
            {
                addictiveness = 0f,
                chemical = ElixirOfDefilation,
                existingAddictionSeverityOffset = 0,
                isCombatEnhancingDrug = false,
                largeOverdoseChance = 1f,
                minToleranceToAddict = 1f,
                needLevelOffset = 0
            }
        };

        public static HediffWithComps hediff = new HediffWithComps()
        {
            ageTicks = 36288000,
            def = new HediffDef()
            {
                defName = "Defilation",
                label = "defiling",
                labelNoun = "defilation",
                defaultLabelColor = new UnityEngine.Color(0.294f, 0, 0.510f),
                maxSeverity = 1.0f,
                isBad = false,
                initialSeverity = 1.0f,
                lethalSeverity = 0,
                stages = UndeadProps.DecompositionStagesDef.Select(
                    s => new HediffStage()
                    {
                        label = s.label,
                        hungerRateFactor = s.hungerRateFactor,
                        capMods = new List<PawnCapacityModifier>()
                        {
                            new PawnCapacityModifier()
                            {
                                capacity = PawnCapacityDefOf.Consciousness,
                                offset = -1
                            }
                        },
                        becomeVisible = true,
                        statOffsets = new List<StatModifier>()
                        {
                            new StatModifier()
                            {
                                stat = StatDefOf.
                            }
                        }
                    }
                )
            }
        };
    }
}
