using static System.Console;
Clear();

Write("Введите номер дня недели: ");
int i = Convert.ToInt32(ReadLine()!);

switch(i)
 {
     case 1:
         {
         WriteLine("Понеделдьник");
         break;
         }
     case 2:
         {
         WriteLine("Вторник");
         break;
         }

     case 3:
         {
         WriteLine("Среда");
         break;
         }
     case 4:
         {
         WriteLine("Четверг");
         break;
         }
    case 5:
        {
            WriteLine("Пятница");
            break;
        }
    case 6:
        {
            WriteLine("Суббота");
            break;
        }
    case 7:
        {
            WriteLine("Воскресенье");
            break;
        }
         default:
         {
             WriteLine("Введите корректный номер дня недели!");
             break;
         }
 }
