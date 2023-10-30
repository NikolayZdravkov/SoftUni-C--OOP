namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList rand = new RandomList();
            rand.Add("a");
            rand.Add("b");
            rand.Add("c");
            rand.Add("d");

            Console.WriteLine("The removed random value is:");
            Console.WriteLine(rand.RandomString());

            Console.WriteLine(String.Join(", ", rand));
        }
    }
}