namespace binary_search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int upper = ints.GetUpperBound(0);
            int lower = 0;
            Console.WriteLine("what number are you looking for? ");
            int target = Convert.ToInt32(Console.ReadLine);
            int mid;
            bool found = false;
            while (lower < upper && found == false )
            {
                mid = (lower + upper) / 2;
                if (target == ints[mid])
                {
                    found = true;
                }
            }
        }
    }
}
