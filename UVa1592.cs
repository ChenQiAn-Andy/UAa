using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVa_OJ
{
    internal class UVa1592 : IAlgorithm
    {
        public void Exec( )
        {
            int m = Convert.ToInt32( Console.ReadLine( ) );
            int n = Convert.ToInt32( Console.ReadLine( ) );
            string[ , ] db = new string[ m , n ];
            for ( int i = 0 ; i < m ; i++ )
            {
                for ( int j = 0 ; j < n ; j++ )
                {
                    db[ i , j ] = Console.ReadLine( );
                }
            }
            //
            List<string> list = new List<string>( );
            Dictionary<string , int> dict = new Dictionary<string , int>( );
            foreach ( var val in db )
            {
                if ( dict.ContainsKey( val ) )
                {
                    continue;
                }
                list.Add( val );
                dict.Add( val , list.Count - 1 );
            }
            //
            Dictionary<(int, int) , int> memo = new Dictionary<(int, int) , int>( );
            for ( int c1 = 0 ; c1 < n ; c1++ )
            {
                for ( int c2 = c1 + 1 ; c2 < n ; c2++ )
                {
                    for ( int r = 0 ; r < m ; r++ )
                    {
                        int id0 = dict[ db[ r , c1 ] ];
                        int id1 = dict[ db[ r , c2 ] ];
                        if ( memo.ContainsKey( (id0, id1) ) )
                        {
                            int row = memo[ (id0, id1) ];
                            Console.WriteLine( $"{row},{r},{c1},{c2}" );
                            return;
                        }
                        memo.Add( (id0, id1) , r );
                    }
                }
            }
        }
    }
}
