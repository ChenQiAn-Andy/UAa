using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVa_OJ
{
    internal class UVa455 : IAlgorithm
    {
        public void Exec( )
        {
            char[ ] seq = Console.ReadLine( ).ToArray( );
            int time = 1, n = seq.Length;
            while ( time < n )
            {
                for ( int i = 0 ; i < time ; i++ )
                {
                    char ch = seq[ i ];
                    for ( int j = i + time ; j < n ; j += time )
                    {
                        if ( ch != seq[ j ] )
                        {
                            goto NEXT;
                        }
                    }
                    goto END;
                }
                break;
            NEXT:
                time++;
            }
        END:
            Console.WriteLine( time );
        }
    }
}
