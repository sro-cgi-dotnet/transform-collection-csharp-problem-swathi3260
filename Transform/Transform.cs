using System;
using System.Linq;
using System.Collections.Generic;

namespace Transform
{
    public delegate int delegateFunction(int x);
    public static class Transform 
    {
        public static int[] Map(this int[] a1,delegateFunction equation){
              for(int i=0;i<a1.Length;i++)  {
                  a1[i]=equation(a1[i]);
              }
              return a1;
        }

}
}