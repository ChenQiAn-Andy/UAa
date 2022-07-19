using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVa_OJ
{
    internal class UVa227 : IAlgorithm
    {
        private Dictionary<char , (int, int)> move = new Dictionary<char , (int, int)>( )
        {
            [ 'A' ] = (-1, 0) ,
            [ 'B' ] = (1, 0) ,
            [ 'L' ] = (0, -1) ,
            [ 'R' ] = (0, 1)
        };

        public void Exec( )
        {
            int rows = 5, cols = 5;
            Console.WriteLine( "Input rows and cols of the matrix:" );
            rows = int.Parse( Console.ReadLine( ) );
            cols = int.Parse( Console.ReadLine( ) );
            string[ ][ ] grids = new string[ rows ][ ];

            Console.WriteLine( "Input data of the matrix:" );
            int r0 = 0, c0 = 0;
            for ( int r = 0 ; r < rows ; r++ )
            {
                var row = Console.ReadLine( ).Split( " " ).ToArray( );
                grids[ r ] = row;
                int c = Array.IndexOf( row , "_" );
                if ( c != -1 )
                {
                    r0 = r;
                    c0 = c;
                }
            }

            Console.WriteLine( "Input a process sequence:" );
            char[ ] procs = Console.ReadLine( ).ToArray( );
            foreach ( var m in procs )
            {
                (int dr, int dc) = move[ m ];
                int tr = r0 + dr, tc = c0 + dc;
                if ( tr < 0 || rows <= tr || tc < 0 || cols <= tc )
                {
                    Console.WriteLine( "There are some invalid processes" );
                    break;
                }

                string tar = grids[ tr ][ tc ];
                grids[ tr ][ tc ] = "_";
                grids[ r0 ][ c0 ] = tar;

                r0 = tr;
                c0 = tc;
            }

            Console.WriteLine( string.Join( "\n" , grids.Select( rows => string.Join( " " , rows ) ) ) );
        }
    }
}
