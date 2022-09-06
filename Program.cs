int i = 0;
int si = 999;
int ze = 0;
int ari = 0;
string [] ar = new string [si];
Console.WriteLine("Введите 4 строки: ");
Console.WriteLine("[");
bool ent = true;
while (ent == true) 
{
    if (i<4) 
    {
        string s = Convert.ToString(Console.ReadLine());
        ar[ari] = s;
        ari++;
        ze++;
        i++;
    }
    else if (i==4) 
    {
        Console.WriteLine("");
        Console.WriteLine("Продолжить?: y/n");
        string answ = Convert.ToString(Console.ReadLine());
        string y = "y";
        string n = "n";
        if (answ==n) {ent = false;}
        else if (answ==y) {i = 0; Console.WriteLine(""); Console.WriteLine("[");}
        else {Console.WriteLine("Введено некорректное значение. Повторите попытку.");}
    }
}
Console.WriteLine("\b\b]");
string [] ray = new string [ze];
for(i = 0; i<ze; i++)
{
    ray[i] = ar[i];
}
//string [] ray = {"hello", "2", "world", ":-("};
Console.WriteLine("");
Console.Write("Строки, длина которых меньше/равна 3: [");
for(i = 0; i<ray.Length; i++)
{
    if (ray[i].Length<=3) { Console.Write(ray[i] + ", "); }
}
Console.Write("\b\b]");