using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAa
{
    internal class UVa1584 : IAlgorithm
    {
        public void Exec( )
        {
            char[ ] seq = Console.ReadLine( ).ToArray( );
            int n = seq.Length;
            int offset = 0, longest = 0;
            for(int j=1 ;j<n ; j++ )
            {
                int k = 0;
                while(k<n )
                {
                    if ( seq[ ( offset + k ) % n ] < seq[(j+ k) % n ] )
                    {
                        break;
                    }
                    k++;
                }
                if ( longest < k )
                {
                    offset = j;
                    longest = k;
                }
            }
            string min = string.Join( "" , seq.Select( ( _ , index ) => seq[ ( index + offset ) % n ] ) );
            Console.WriteLine( min );
        }
    }
}
