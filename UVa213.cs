using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVa_OJ
{

    internal class UVa213 : IAlgorithm
    {
        public void Exec( )
        {
            string head = @"$#**\";
            var memo = new Dictionary<string , char>( );
            for ( int i = 0, bits = 1, val = 0 ; i < head.Length ; )
            {
                if ( val == Math.Pow( 2 , bits ) - 1 )
                {
                    val = 0;
                    bits++;
                    continue;
                }
                var code = Convert.ToString( val , 2 ).PadLeft( bits , '0' );
                memo.Add( code , head[ i ] );
                val++;
                i++;
            }

            string msg = "0100000101101100011100101000";
            StringBuilder result = new StringBuilder( );
            for ( int i = 0, bits = 3 ; ; )
            {
                var tag = msg.Substring( i , bits );
                if ( tag == "000" )
                {
                    Console.WriteLine( result.ToString( ) );
                    return;
                }
                while ( i < msg.Length )
                {
                    i += bits;
                    bits = Convert.ToInt32( tag , 2 );
                    var code = msg.Substring( i , bits );
                    if ( Convert.ToInt32( code , 2 ) == ( int ) Math.Pow( 2 , bits ) - 1 )
                    {
                        i += bits;
                        bits = 3;
                        break;
                    }
                    result.Append( memo[ code ] );
                }
            }
        }
    }
}
