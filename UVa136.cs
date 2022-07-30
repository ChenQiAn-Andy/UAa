using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVa_OJ
{
    internal class UVa136 : IAlgorithm
    {
        private List<int> primes = new List<int>( ) { 2 , 3 , 5 };

        public void Exec( )
        {
            int n = int.Parse( Console.ReadLine( ) );
            HashSet<long> memo = new HashSet<long>( ) { 1 };
            List<long> ugly = new List<long>( ) { 1 };
            for ( int i = 1 ; i < n ; i++ )
            {
                var e = ugly.First( );
                ugly.RemoveAt( 0 );
                foreach ( var p in primes )
                {
                    long tmp = p * e;
                    if ( !memo.Contains( tmp ) )
                    {
                        memo.Add( tmp );
                        ugly.Add( tmp );
                    }
                }
                ugly.Sort( );
            }
            Console.WriteLine( ugly.First( ) );
        }
    }
}