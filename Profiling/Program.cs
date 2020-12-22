using System;
using System.Threading;


namespace Profiling
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Inside main()");
			string numoffunc = Console.ReadLine();

			int i = 0;

			for (; i < 0xffffff; i++) ;
			switch (numoffunc)
			{
				case "first":
					FirstFuction();
					break;
				case "second":
					SecondFunction();
					break;
				case "third":
					ThirdFunction();
					break;
				default:
					break;
			}
		}
		static void FirstFuction()
		{
			for (int i = 0; i < 10; i++)
			{
				//process 
				Thread.Sleep(1000);
			}

			return;
		}

		static void SecondFunction()
		{
			for (int i = 0; i < 20; i++)
			{
				//process 
				Thread.Sleep(1000);
			}
			return;
		}
		static void ThirdFunction()
		{
			for (int i = 0; i < 40; i++)
			{
				//process 
				Thread.Sleep(1000);
			}
			return;
		}
	}
}
