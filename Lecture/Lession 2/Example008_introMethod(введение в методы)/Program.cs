﻿
//начало метода поиск максимума из 3
int Max (int arg1, int arg2, int arg3) 
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
//Конец метода

int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 2311;
int c2 = 33;
int a3 = 313;
int b3 = 23111;
int c3 = 33;

//int max1 = Max(a1,b1,c1);//первая тройка
//int max2 = Max(a2,b2,c2);//вторая тройка
//int max3 = Max(a3,b3,c3);//третья тройка
//int max = Max(max1,max2,max3); //максимум из трех

int max = Max(
    Max(a1,b1,c1),
    Max(a2,b2,c2),
    Max(a3,b3,c3));

Console.WriteLine(max);

/*
int max = a1; //стихийный подход
if (b1 > max) max = b1;
if (c1 > max) max = c1;

if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;

if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;

Console.WriteLine(max);
*/
