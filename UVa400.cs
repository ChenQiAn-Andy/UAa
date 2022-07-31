using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVa_OJ
{
    internal class UVa400 : IAlgorithm
    {
        public void Exec( )
        {
            int n = int.Parse( Console.ReadLine( ) );
            List<string> list = new List<string>( n );
            int M = 0;
            while ( 0 < n-- )
            {
                var name = Console.ReadLine( );
                M = Math.Max( M , name.Length );
                list.Add( name );
            }
            list.Sort( );
            const int ROWS = 4;
            int cols = ( int ) Math.Ceiling( ( double ) list.Count / ROWS );
            for ( int r = 0 ; r < ROWS ; ++r )
            {
                List<string> line = new List<string>( cols );
                for ( int c = 0 ; c < cols ; ++c )
                {
                    int index = c * ROWS + r;
                    if ( list.Count <= index ) 
                    { 
                        break;
                    }
                    line.Add( list[ index ] );
                }
                Console.WriteLine( string.Join( string.Empty , line.Select( name => name.PadRight( M + 2 , ' ' ) ) ) );
            }
        }
    }
}
