using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVa_OJ
{
    internal class UVa133 : IAlgorithm
    {
        private int[ ] queue;

        private bool Over( )
        {
            return 0 == queue.Count( e => e == 1 );
        }

        private bool Loop( int count , ref int index , int stepSize )
        {
            int c = count;
            while ( 0 < c )
            {
                if ( Over( ) )
                {
                    return true;
                }
                int i = ( index + stepSize + queue.Length ) % queue.Length;
                if ( queue[ i ] == 1 )
                {
                    --c;
                }
                index = i;
            }
            return false;
        }

        public void Exec( )
        {
            int n = 10, k = 4, m = 3;
            queue = new int[ n ];
            Array.Fill( queue , 1 );

            int a = -1, b = n;
            while ( !Over( ) )
            {
                bool isOver = Loop( k , ref a , 1 ) || Loop( m , ref b , -1 );
                if ( isOver )
                {
                    return;
                }

                queue[ a ] = queue[ b ] = 0;

                Console.WriteLine( $"{a + 1},{b + 1}" );
            }
        }
    }
}
