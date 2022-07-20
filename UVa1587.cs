using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVa_OJ
{
    internal class UVa1587 : IAlgorithm
    {
        public void Exec( )
        {
            var planes = new Dictionary<(int, int) , int>( );
            for(int i=0 ;i<6 ; ++i )
            {
                (int w, int h) = (int.Parse( Console.ReadLine( ) ), int.Parse( Console.ReadLine( ) ));
                if ( planes.ContainsKey( (w, h) ))
                {
                    ++planes[ (w, h) ];
                }
                else
                {
                    planes.Add( (w, h) , 1 );
                }
            }
            int n=planes.Count;
            if ( n == 1 )
            {
                if( planes.Keys.Count( plane => plane.Item1 == plane.Item2 ) == 0 )
                {
                    goto ERROR;
                }
                else
                {
                    Console.WriteLine( "It's a cube." );
                }
                return;
            }
            
            if(n == 2 )
            {
                int w=0,h=0,s=0;
                foreach(var plane in planes )
                {
                    var size = plane.Key;
                    if ( size.Item1 == size.Item2 )
                    {
                        s= size.Item2;
                        if ( plane.Value != 2 )
                        {
                            goto ERROR;
                        }
                    }
                    else
                    {
                        w=size.Item1;
                        h=size.Item2;
                        if ( plane.Value != 4 )
                        {
                            goto ERROR;
                        }
                    }
                }
                if ( w != s && h != s )
                {
                    goto ERROR;
                }

                Console.WriteLine( "It's a cuboid." );
                return;
            }
            
            ERROR:
            Console.WriteLine( "Invalid." );
        }
    }
}
