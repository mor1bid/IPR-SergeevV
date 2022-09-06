int si = 0;
int answ = 1;
Console.Write("Введите строку: ");
bool ent = true;
while (ent == true) 
{
    int i = 0;
    string s = Convert.ToString(Console.ReadLine());
    si++;
    if (i==4) 
        { 
            Console.WriteLine("Продолжить? 1/0");
            answ = Convert.ToInt32(Console.ReadLine());
            if (answ==0) { ent = false; }
            else if (answ==1) { ent = true; }
            else Console.WriteLine("Введено некорректное значение.");
        }
}
string [] ray = new string [si];
//string [] ray = {"hello", "2", "world", ":-("};
Console.Write("[");
for(int i = 0; i<ray.Length; i++)
{
    if (ray[i].Length<=3) { Console.Write(ray[i] + ", "); }
}
Console.Write("\b\b]");