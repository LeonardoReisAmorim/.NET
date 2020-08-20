using System;

namespace Hello_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static int comparaidades(int a, int b){
            int m;
            if(a==b){
                return 0;
            }
            else if(a>b){
                m = a;
            }
            else{
                m = b;
            }
            return m;
        }
    }
}
