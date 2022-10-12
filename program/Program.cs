// Задача. Написать программу, которая из имеющегося массива строк формирует массив 
// из строк, длина которых меньше либо равна 3 символа.


Console.Clear();

string [] Str1 =  {"one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten"};
Console.Write("[" + String.Join(", ",Str1) + "] —> ");

int L = Str1.Length;
string [] Str2 = new string[L];

int j=0;

for (int i=0;i<L;i++)
{
   if (Str1[i].Length <=3)
        {
            Str2[j]=Str1[i];
            j++;
        }
}    
Array.Resize(ref Str2,j);


Console.Write("[" + String.Join(", ",Str2) + "]");
Console.WriteLine();








