namespace BaldursStarGate2dot0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RngSeed();
            Console.ReadKey();
            Console.CursorVisible = false;
            //Console.SetWindowSize(20, 20);
            //Console.SetBufferSize(20, 20);
            Console.Clear();
            new Menu();
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