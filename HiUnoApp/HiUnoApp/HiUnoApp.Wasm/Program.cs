using System;

namespace HiUnoApp.Wasm
{
	public class Program
	{
		private static App _app;

		static void Main(string[] args)
        {
            Console.WriteLine("go");
            _app = new App();
		}
	}
}
