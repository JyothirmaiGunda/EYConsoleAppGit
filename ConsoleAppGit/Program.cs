namespace ConsoleAppGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(DateTime.Now.ToLongDateString()); 
        }
        public int sum(int x,int y)
        {
            return x + y;
        }
        public int multiply(int x,int y)
        {
            return x*y;
        }
        public int divide(int x, int y) //local changes commited in local repos
        {
            return x / y;
        }
        public int mimus(int x,int y)
        {
            return x-y;
        }
    }
}
