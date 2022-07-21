using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVa_OJ
{
    internal class UVa1588 : IAlgorithm
    {
        private int Traverse( List<int> a , List<int> b )
        {
            int n1 = a.Count, n2 = b.Count;
            for ( int offset = 0 ; offset < n2 ; ++offset )
            {
                for ( int i = 0 ; i < n1 ; ++i )
                {
                    int j = i + offset;
                    if ( n2 <= j )
                    {
                        return offset + n1;
                    }
                    if ( 3 < a[ i ] + b[ j ] )
                    {
                        goto NEXT;
                    }
                }
                return n2;
            NEXT:;
            }
            return n1 + n2;
        }

        public void Exec( )
        {
            List<int> a = Console.ReadLine( ).Split( " " ).Select( e => int.Parse( e ) ).ToList( );
            List<int> b = Console.ReadLine( ).Split( " " ).Select( e => int.Parse( e ) ).ToList( );
            if ( a.Count > b.Count )
            {
                var tmp = a;
                a = b;
                b = tmp;
            }
            int res1 = Traverse( a , b );
            a.Reverse( );
            int res2 = Traverse( a , b );
            Console.WriteLine( $"{Math.Min( res1 , res2 )}" );
        }
    }
}
