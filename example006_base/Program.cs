﻿int a = 5;
int b = 1;
int c = 9;
int d = 2;
int e = 4;
int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("max = ");
Console.WriteLine(max);