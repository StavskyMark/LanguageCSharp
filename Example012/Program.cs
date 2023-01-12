using static System.Console;
Clear();
Write("Введите координаты x: ");
int x = int.Parse(ReadLine()!);
Write("Введите координаты y: ");
int y = int.Parse(ReadLine()!);

// switch(i)
// {
//     case 1:
//         {
//         WriteLine("x>0 y>0");
//         break;
//         }
//     case 2:
//         {
//         WriteLine("x<0 y>0");
//         break;
//         }
//     case 3:
//         {
//         WriteLine("x<0 y<0");
//         break;
//         }
//     case 4:
//         {
//         WriteLine("x>0 y<0");
//         break;
//         }
//         default:
//         {
//             WriteLine("Ошибка");
//             break;
//         }
// }

// if (i < 1 || i > 4)
//  {
//      WriteLine("Ошибка");
//      return;
//  }
 if (x > 0 && y > 0)
 {
     WriteLine("I Четверть");
 }
 if (x < 0 && y > 0)
 {
     WriteLine("II Четверть");
 }
 if (x < 0 && y < 0)
 {
     WriteLine("III Четверть");
 }
 if (x > 0 && y < 0)
 {
     WriteLine("IV Четверть");
 }
