int si = 0;
string [] ray = new string [si];
int answ = 1;
Console.WriteLine("Введите строку: ");
Console.Write("[");
bool ent = true;
while (ent == true) 
{
    int i = 0;
    string s = Convert.ToString(Console.ReadLine());
    ray[si] = s;
    Console.Write(ray[i] + ", ");
    si++;
    if (i==4) 
        { 
            Console.WriteLine("Продолжить? 1/0");
            answ = Convert.ToInt32(Console.ReadLine());
            if (answ==0) { ent = false; Console.Write("\b\b]");}
            else if (answ==1) { ent = true; }
            else Console.WriteLine("Введено некорректное значение.");
        }
}
//string [] ray = {"hello", "2", "world", ":-("};
Console.Write("[");
for(int i = 0; i<ray.Length; i++)
{
    if (ray[i].Length<=3) { Console.Write(ray[i] + ", "); }
}
 Console.Write("\b\b]");