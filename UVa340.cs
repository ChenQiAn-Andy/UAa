using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVa_OJ
{
    internal class UVa340:IAlgorithm
    {
        public void Exec( )
        {
            var res = Foo( new int[ ] { 1 , 3 , 5 , 5 } , new int[ ] { 1 , 3 , 5 , 5 } );
        }

        public int[ ] Foo( int[ ] answer , int[ ] test )
        {
            int a = 0, b = 0;

            for ( int i = 0, n = answer.Length ; i < n ; ++i )
            {
                if ( answer[ i ] == test[ i ] )
                {
                    ++a;
                }
                b += test.Count( e => e == answer[ i ] );
            }

            return new int[ ] { a , b - a };
        }
    }
}
