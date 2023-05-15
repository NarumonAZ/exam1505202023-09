using System;

class Program{

    static void Compare(float a, float b,float c,float d, float e) {
    float f = b * d;
    float g = c * e;
    float h = c;
    while(a < f) {
        if (a < f) {
            a = a + h;
            --e;
            b = b + d;
            --c;
        }else if (a == f){
            Console.WriteLine("{0}",a);
            Console.WriteLine("{0}",b);
            Console.WriteLine("{0}",c);
            Console.WriteLine("{0}",d);
            Console.WriteLine("{0}",e);
        }

    }
    if( b <= a ){
            Console.WriteLine("Enough Water");
                float vleft = c;
            Console.WriteLine("{0} left",vleft);
        } else {
            Console.Write("Not Enough Water");
        }

    if( e >= 0 ){
            Console.WriteLine("Overflow Water");
    }
}


  static void Main(string[] args){
    //water welfare
    float volumemax = float.Parse(Console.ReadLine()); //10 a
    float volumedrink = float.Parse(Console.ReadLine()); //4 b
    float volumefill = float.Parse(Console.ReadLine()); //5 c
    float tineday = float.Parse(Console.ReadLine());
    float timedrink = float.Parse(Console.ReadLine()); //5 d
    float timefill = float.Parse(Console.ReadLine()); //14 e

    Compare(volumemax,volumedrink,volumefill,timedrink,timefill);
    
    //treasurer
    float b1 = float.Parse(Console.ReadLine());
    float b2 = float.Parse(Console.ReadLine());
    float b3 = float.Parse(Console.ReadLine());

        do {
            float a = float.Parse(Console.ReadLine());
            b1 = b1 - a;
        }while(b1 > 0);

         do {
            float a = float.Parse(Console.ReadLine());
            b2 = b2 - a;
        }while(b3 < 0);

                do {
            float a = float.Parse(Console.ReadLine());
            b3 = b3 - a;
        }while(b3 < 0);

    Console.WriteLine(b1);
    Console.WriteLine(b2);
    Console.WriteLine(b3);

} 
}