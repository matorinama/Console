﻿int a = 1;
int b = 3;
int c = 4;
int d = 2;
int e = 1;
int max = a;

if (b>max) max = b;
if (c>max) max = c;
if (d>max) max = d;
if (e>max) max = e;

Console.Write("max = ");
Console.WriteLine(max);