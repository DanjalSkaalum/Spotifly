namespace Spotifly.Model
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Data.AddData();

            foreach (var artist in Data.Artists)
            {
                Console.WriteLine(artist);
            }
        }
    }
}
