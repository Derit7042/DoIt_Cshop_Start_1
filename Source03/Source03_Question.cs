﻿using System;

class MainClass
{
    public static void Main(string[] args)
    {
        byte celsius = 27;
        double fahrenheit = (celsius * 1.8) + 32;
        Console.WriteLine("섭씨 온도 " + celsius + "도는 화씨 온도 " + fahrenheit + "도입니다.");
    }
}