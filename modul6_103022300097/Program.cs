// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        SayaTubeVideo video1 = new SayaTubeVideo("Tutorial Design By Contract - M.ARZU KIRANA BERUTU");
        video1.PrintVideoDetails();

        video1.IncreasePlayCount(100);
        video1.PrintVideoDetails();
    }
}

