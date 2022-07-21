using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVa_OJ
{
    internal class UVa1339 : IAlgorithm
    {
        public void Exec( )
        {
            char[ ] src = Console.ReadLine( ).ToArray( );
            Array.Sort( src );

            char[ ] dest = Console.ReadLine( ).ToArray( ).Select( ch => ch == 'z' ? 'a' : Convert.ToChar( ch + 1 ) ).ToArray( );
            Array.Sort( dest );

            for ( int i = 0 ; i < src.Length ; i++ )
            {
                if ( src[ i ] != dest[ i ] )
                {
                    Console.WriteLine( "False" );
                    return;
                }
            }
            Console.WriteLine( "True" );
        }
    }
}
