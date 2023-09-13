namespace BaldursStarGate2dot0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CreateSomeEquipment();
            //RngSeed();
            //Console.ReadKey();
            Console.CursorVisible = false;
            //Console.SetWindowSize(20, 20);
            //Console.SetBufferSize(20, 20);
            Console.Clear();
            new Menu();
        }

        static void CreateSomeEquipment()
        {
            AllEquipment ae = new AllEquipment();
            Equipment sword = new() { Name = "Claymore", Damage = 10, Gold = 100 };
            Equipment shield = new() {Name = "Hyrule Shield", Armor = 10, Gold = 150};
            ae.EquipmentList = new() { sword, shield };
            Io.Save(ae);
        }

        private static void RngSeed()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Game.Rnd.Next(0, 10)); 
            }
        }
    }
}