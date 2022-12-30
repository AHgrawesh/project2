namespace project2
{
    class project2
    {
        static void Main(string[] args)
        {
            int x, y, sum;
            int n1, n2;
            Console.Write("Please, enter the lowest number : ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Please, enter the highest number : ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("The Perfect numbers between {0} and {1} are  : ", n1, n2);
            for (x = n1; x <= n2; x++)
            {
                y = 1;
                sum = 0;
                while (y < x)
                {
                    if (x % y == 0)
                        sum = sum + y;
                    y++;
                }
                if (sum == x)
                    Console.Write("\n{0} ", x);
            }
        }
    }
}