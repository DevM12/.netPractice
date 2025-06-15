namespace CollectionsInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lists
            List<string> colors = new List<string>();
            colors.Add("Red");
            colors.Add("Blue");
            colors.Add("Red"); 
            colors.Add("Green");

            colors.Remove("Red");
            colors.Insert(0, "Yellow");

            foreach(string color in colors)
            {
                Console.WriteLine(color);
            }

        }
    }
}