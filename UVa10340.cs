using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVa_OJ
{
    internal class UVa10340 : IAlgorithm
    {
        public void Exec( )
        {
            char[ ] s = Console.ReadLine( ).ToArray( );
            char[ ] t = Console.ReadLine( ).ToArray( );
            for ( int i = 0, j = -1 ; i < s.Length ; i++ )
            {
                int tmp = Array.IndexOf( t , s[ i ] , j+1 );
                if ( tmp == -1 )
                {
                    Console.WriteLine( "false" );
                    return;
                }
                j = tmp;
            }
            Console.WriteLine( "true" );
        }
    }
}
