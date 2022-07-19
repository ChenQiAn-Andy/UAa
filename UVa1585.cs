using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVa_OJ
{
    internal class UVa1585 : IAlgorithm
    {
        public void Exec( )
        {
            char[ ] seq = Console.ReadLine( ).ToArray( );
            int c = 0;
            int score = seq.Aggregate( 0 , ( count , ch ) =>
            {
                if ( ch == 'X' )
                {
                    c = 0;
                }
                else
                {
                    ++c;
                }
                count += c;
                return count;
            } );
            Console.WriteLine( score );
        }
    }
}
