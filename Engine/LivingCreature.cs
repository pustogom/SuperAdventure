using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class LivingCreature
    {
        public int CurrentHitPoints { get; set; }
        public int MaxHitpPoints { get; set; }

        public LivingCreature(int currentHitPoints, int maxHitpPoints)
        {
            CurrentHitPoints = currentHitPoints;
            MaxHitpPoints = maxHitpPoints;
        }
    }
}
