namespace BaldursStarGate2dot0
{
    public class Player : Creature
    {
        public string? Name { get; set; }
        public int Mana { get; set; }

        public override string? ToString()
        {
            return Name;
        }
    }
}
