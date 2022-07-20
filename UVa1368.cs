using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVa_OJ
{
    internal class UVa1368 : IAlgorithm
    {
        public void Exec( )
        {
            int m = int.Parse( Console.ReadLine( ) );
            char[ ][ ] seq = new char[ m ][ ];
            int n = int.Parse( Console.ReadLine( ) );
            for ( int i = 0 ; i < m ; i++ )
            {
                seq[ i ] = Console.ReadLine( ).ToArray( );
            }

            StringBuilder res = new StringBuilder( );
            int hamming = 0;
            for ( int j = 0 ; j < n ; j++ )
            {
                var memo = new Dictionary<char , int>( ) { [ 'A' ] = 0 , [ 'C' ] = 0 , [ 'T' ] = 0 , [ 'G' ] = 0 };
                for ( int k = 0 ; k < m ; k++ )
                {
                    ++memo[ seq[ k ][ j ] ];
                }
                var col = memo.Select( pair => pair ).ToList( );
                col.Sort( ( a , b ) =>
                {
                    if ( a.Value == b.Value )
                    {
                        return a.Key < b.Key ? -1 : 1;
                    }
                    return a.Value < b.Value ? -1 : 1;
                } );
                var tar = col.Last( );
                res.Append( tar.Key );
                hamming += m - tar.Value;
            }
            Console.WriteLine( $"{res.ToString( )}:{hamming}" );
        }
    }
}
