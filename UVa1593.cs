using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVa_OJ
{
    internal class UVa1593 : IAlgorithm
    {
        public void Exec( )
        {
            int n = Convert.ToInt32( Console.ReadLine( ) );
            List<List<string>> lines = new List<List<string>>( n );
            int i = -1, cols = 0;
            while ( ++i < n )
            {
                string line = Console.ReadLine( );
                lines.Add( line.Split( " " , StringSplitOptions.RemoveEmptyEntries ).ToList( ) );
                cols = Math.Max( cols , lines[ i ].Count );
            }
            i = -1;
            List<int> memo = new List<int>( cols );
            while ( ++i < cols )
            {
                int max = 0;
                foreach ( var line in lines )
                {
                    if ( line.Count <= i )
                    {
                        continue;
                    }
                    max = Math.Max( max , line[ i ].Length );
                }
                memo.Add( max );
            }
            List<string> result = new List<string>( n );
            foreach ( var line in lines )
            {
                for ( int j = 0 ; j < line.Count ; ++j )
                {
                    line[ j ] = line[ j ].PadRight( memo[ j ] , ' ' );
                }
                result.Add( string.Join( " " , line ) );
            }
            Console.Write( string.Join( '\n' , result ) );
        }
    }
}
