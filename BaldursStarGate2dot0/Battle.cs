namespace BaldursStarGate2dot0
{
    internal class Battle
    {
        public Battle(Player player, Monster monster)
        {
            Combat(player, monster);
        }

        public Battle() { }

        public bool Combat(Player player, Monster monster)
        {
            Console.Clear();
            Gui.ShowPlayer(player);
            Gui.ShowMonster(monster);
            Gui.Print(3, 5, $"{player} opens a stargate, and out jumps a {monster}.");
            bool continueBattle = true;
            int round = 1;
            while (continueBattle)
            {
                if (lineCounter > 20)
                {
                    Console.Clear();
                    Gui.ShowPlayer(player);
                    Gui.ShowMonster(monster);
                    lineCounter = 6;
                }

                Gui.Print(3, 4, "Round " + round++);
                Console.ReadKey();
                if (WhoStarts() == 0)
                {
                    continueBattle = Attack(player, monster);
                    //Player wins
                    if (!continueBattle)
                    {
                        //TODO F...ed up
                        player.EquipmentList.AddRange(monster.EquipmentList);
                        player.Gold += monster.Gold;
                        return true;
                    }// break;
                    continueBattle = Attack(monster, player);
                    if (!continueBattle) { return false; }// break;
                }
                else
                {
                    continueBattle = Attack(monster, player);
                    if (!continueBattle) return false;// break;
                    continueBattle = Attack(player, monster);
                    if (!continueBattle)
                    {
                        player.EquipmentList.AddRange(monster.EquipmentList);
                        player.Gold += monster.Gold;
                        return true;
                    }
                }
            }
            return true;
        }


        int lineCounter = 6;
        private bool Attack(Creature attacker, Creature defender)
        {
            int roll = AttackRoll();
            Gui.Print(3, lineCounter++, $"{attacker} swings, and rolls a " + roll);
            roll = ArmorReduction(roll, defender);
            defender.ReduceHealth(roll);

            //We check if someone died, and if, we return false, so we can stop the battle
            if (defender.Health <= 0)
            {
                Gui.Print(3, lineCounter, $"{defender} have died.");
                Console.ReadKey();
                return false;
            }
            return true;
        }

        private int ArmorReduction(int att, Creature creature)
        {
            return Math.Max(0, att - creature.Armor);
        }

        //TODO Add modifier dependent on weapon or defender 
        private int AttackRoll()
        {
            int att = Game.Rnd.Next(Game.Dice);
            return att;
        }

        private int WhoStarts()
        {
            return Game.Rnd.Next(2);
        }
    }
}
