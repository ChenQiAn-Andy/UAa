using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVa_OJ
{
    internal class UVa1594 : IAlgorithm
    {
        public void Exec( )
        {
            var src = (8, 11, 2, 7, 8);
            var zero = (0, 0, 0, 0, 0);
            var tmp = src;

            for ( int i = 0 ; i < 1000 ; i++ )
            {
                tmp.Item1 = Math.Abs( tmp.Item1 - tmp.Item2 );
                tmp.Item2 = Math.Abs( tmp.Item2 - tmp.Item3 );
                tmp.Item3 = Math.Abs( tmp.Item3 - tmp.Item4 );
                tmp.Item4 = Math.Abs( tmp.Item4 - tmp.Item5 );
                tmp.Item5 = tmp.Item1;

                if ( tmp == zero )
                {
                    Console.WriteLine( $"tmp == zero : {tmp == zero} ({i})" );
                    return;
                }
                if ( tmp == src )
                {
                    Console.WriteLine( $"tmp == src : {tmp == src} ({i})" );
                    return;
                }
            }
            Console.WriteLine( "False" );
        }
    }
}
