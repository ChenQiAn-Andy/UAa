using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVa_OJ
{
    internal class UVa1225 : IAlgorithm
    {
        public void Exec( )
        {
            int[ ] memo = new int[ 10 ];
            int n = int.Parse( Console.ReadLine( ) );
            for ( int i = 1 ; i <= n ; i++ )
            {
                int j = i;
                while ( 0 < j )
                {
                    ++memo[ j % 10 ];
                    j /= 10;
                }
            }
            for ( int i = 0 ; i < memo.Length ; ++i )
            {
                Console.WriteLine( $"{i} : {memo[ i ]}" );
            }
        }
    }
}
