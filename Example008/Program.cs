﻿using static System.Console;
Clear();

Write("Введите число a: ");
int a = int.Parse(ReadLine());
Write("Введите число b: ");
int b = int.Parse(ReadLine());

WriteLine(a%b==0?"Кратное":$"Некратное, остаток {a%b}");
