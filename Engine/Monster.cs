using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Monster : LivingCreature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaxDamage {  get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold {  get; set; }

        public Monster(int id, string name, int maxDamage, int rewardExperiencePoints, 
                int rewardGold, int currentHitPoints, int maxHitPoints)
                : base(currentHitPoints, maxHitPoints)
        {
            ID = id;
            Name = name;
            MaxDamage = maxDamage;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;
        }
    }
}
