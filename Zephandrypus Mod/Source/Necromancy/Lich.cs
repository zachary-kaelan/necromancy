using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using RimWorld;
using Verse;
using Verse.Sound;

namespace Necromancy
{
    public class Lich
    {
        public PawnComponentsUtility pawnComponents = new PawnComponentsUtility();
        public RaceProperties raceProps = new RaceProperties()
        {
            baseBodySize = 1.0F,
            baseHungerRate = 0,
            baseHealthScale = 1.25F,
            canBePredatorPrey = false,
            foodType = FoodTypeFlags.None,
            hasGenders = true,
            herdAnimal = false,
            herdMigrationAllowed = false,
            intelligence = Intelligence.Humanlike,
            lifeExpectancy = float.MaxValue,
            makesFootprints = false,
            nameCategory = PawnNameCategory.HumanStandard,
            needsRest = false
        };

        public void Debug()
        {
            
        }
        
    }

    
}
