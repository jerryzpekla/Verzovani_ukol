/*
 * Created by SharpDevelop.
 * User: jaros
 * Date: 24.03.2021
 * Time: 12:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Verzovani_Test
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			int counter = 0;
			for (int i = 0; i < 15; i++) {  //Pocita do 15
				counter ++;
			}
			Console.WriteLine(counter);
			
			Console.Write("tenhle vypis je zmena");
			Console.Write("tohle je dalsi zmena");
			
			
			Console.ReadKey(true);
		}
	}
}