using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVa_OJ
{
    internal class UVa10391 : IAlgorithm
    {

        public void Exec( )
        {
            int n = Convert.ToInt32( Console.ReadLine( ) );
            List<string> memo = new List<string>( n );
            for ( int i = 0 ; i < n ; ++i )
            {
                memo.Add( Console.ReadLine( ) );
            }
            memo.Sort( );
            List<string> result = new List<string>( n );
            for ( int i = 0, j = i + 1 ; j < n ; ++j )
            {
                while ( j < n && memo[ j ].IndexOf( memo[ i ] ) != -1 )
                {
                    result.Add( memo[ j ] );
                    ++j;
                }
                i = j;
            }
            Console.WriteLine( string.Join( "," , result ) );
        }
    }
}
