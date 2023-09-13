namespace BaldursStarGate2dot0
{
    internal class Monster : Creature
    { 
        public Monster(List<Equipment> allEquipment)
        {
            CreateMonster(allEquipment);
            Health = MaxHealth;
        }

        public override string? ToString()
        {
            return Type;
        }

        private void CreateMonster(List<Equipment> allEquipment)
        {
            Equipment equipment = allEquipment[Game.Rnd.Next(allEquipment.Count)];
            EquipmentList.Add(equipment);

            switch (Game.Rnd.Next(100))
            {
                case < 20:
                    Type = "Orc";
                    MaxHealth = 150;
                    Armor = 5;
                    Gold = Game.Rnd.Next(100);
                    break;
                case < 40:
                    Type = "Dice Goblin";
                    MaxHealth = 50;
                    Armor = 2;
                    Gold = Game.Rnd.Next(25);
                    break;
                case < 45:
                    Type = "Dragon";
                    MaxHealth = 500;
                    Armor = 20;
                    Gold = Game.Rnd.Next(5000);
                    break;
                case < 100:
                    Type = "Slime";
                    MaxHealth = 10;
                    Armor = 0;
                    Gold = Game.Rnd.Next(5);
                    break;
                default:
                    break;
            }
        }
    }
}
