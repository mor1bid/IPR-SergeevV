int i = 0;
int si = 999;
int ze = 0;
int ari = 0;
string [] ar = new string [si];
Console.WriteLine("Введите строку: ");
Console.Write("[");
bool ent = true;
while (ent == true) 
{
    string s = Convert.ToString(Console.ReadLine());
    ar[ari] = s;
    //Console.Write(ar[i] + ", ");
    ari++;
    ze++;
    i++;
    if (i==4) 
        {
            Console.WriteLine("\b\b]");
            Console.WriteLine("Продолжить?: 1/0");
            int answ = Convert.ToInt32(Console.ReadLine());
            if (answ==0) { ent = false;}
            else if (answ==1) { i = 0; Console.WriteLine("[");}
            else Console.WriteLine("Введено некорректное значение.");
        }
}
string [] ray = new string [ze];
for(i = 0; i<ze; i++)
{
    ray[i] = ar[i];
}
//string [] ray = {"hello", "2", "world", ":-("};
Console.WriteLine("");
Console.Write("[");
for(i = 0; i<ray.Length; i++)
{
    if (ray[i].Length<=3) { Console.Write(ray[i] + ", "); }
}
 Console.Write("\b\b]");