using System;
using AverageConsoleApp;

namespace ConsoleApp1 {
    class Program {
        static void Main( string[] args ) {
            // Тестирование
            var test = new AverageClass< byte >();
            for ( byte i = 0; i < 10; i++ ) {
                test.Add( i );
            }
            var result = test.Average();
            test.Reset();

            var test_string = new AverageClass< DateTime >();

            Console.ReadLine();

        }
    }
}
