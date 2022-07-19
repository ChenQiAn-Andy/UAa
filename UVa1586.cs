using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVa_OJ
{
    internal class UVa1586 : IAlgorithm
    {
        public void Exec( )
        {
            char[ ] seq = Console.ReadLine( ).ToArray( );
            var memo = new Dictionary<char , double>( ) { [ 'C' ] = 12.01 , [ 'H' ] = 1.008 , [ 'O' ] = 16.00 , [ 'N' ] = 14.01 };
            char element = '\0';
            double result = seq.Aggregate( .0 , ( count , ch ) =>
            {
                if ( memo.ContainsKey( ch ) )
                {
                    element = ch;
                    count += memo[ ch ];
                }
                else
                {
                    count += ( ch - '0' - 1 ) * memo[ element ];
                }
                return count;
            } );
            Console.WriteLine( $"{result:F3}" );
        }
    }
}
