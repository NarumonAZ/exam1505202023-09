using System;

class Program{

    static int Compare(int a, int b) {
        if (a <= b) {
           return a; 
        } 
        return b;
    }


  static void Main(string[] args){
    float volumemax = float.Parse(Console.ReadLine());
    float volumedrink = float.Parse(Console.ReadLine());
    //float volumefill = float.Parse(Console.ReadLine());
    //float tineday = float.Parse(Console.ReadLine());
    //float timedrink = float.Parse(Console.ReadLine());
    //float timefill = float.Parse(Console.ReadLine());

    //float result1 = Compare((int)volumedrink, (int)volumemax);
    if(volumedrink <= volumemax){
        Console.Write("Enough Water");
        } else {
            Console.Write("Not Enough Water");
        }


    }


        }
