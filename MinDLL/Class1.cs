namespace MinDLL
{
    public class Class1
    {
        public void Min(int size)
        {
            int SIZE = size;
            var nums = Enumerable.Range(1, SIZE).ToList();
            int[] result = new int[SIZE];
            Random rand = new Random();
            for (int i = 0; i < SIZE; i++)
            {
                result[i] = rand.Next(100);
            }
            foreach (var i in result)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine($" Минимальный элемент равен: {result.Min()}");
        }
    }
}