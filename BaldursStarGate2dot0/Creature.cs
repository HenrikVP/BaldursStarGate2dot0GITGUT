using System.Text.Json.Serialization;

namespace BaldursStarGate2dot0
{
    public abstract class Creature
    {
        //Field
        private int health;
        public int MaxHealth { get; set; }

        //Property. GET returns value of field, SET sets value of field from [value]
        public int Health { 
            get 
            { 
                return health;
            }
            set 
            {
                //if value set for Health property is higher than max,
                //then value is capped at max. THEN health is set.
                if (value > MaxHealth) value = MaxHealth;
                health = value;
                if (this.GetType() == typeof(Player))
                    Gui.ShowPlayer((Player)this);
                else Gui.ShowMonster((Monster)this);
            }
        }
        
        public int Armor { get; set; }
        public string Type { get; set; } = "Unknown";
        public int Gold { get; set; }

        public void ReduceHealth(int damage)
        {
            Health -= damage;
        }
    }
}
