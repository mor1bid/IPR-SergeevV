int i = 0;
int si = 4;
int ari = 0;
string [] ray = new string [si];
Console.WriteLine("Введите строку: ");
Console.Write("[");
bool ent = true;
while (ent == true) 
{
    string s = Convert.ToString(Console.Read());
    ray[ari] = s;
    Console.Write(ray[i] + ", ");
    ari++;
    i++;
    if (i==4) 
        {
            Console.WriteLine("");
            Console.WriteLine("Продолжить?: 1/0");
            int answ = Convert.ToInt32(Console.ReadLine());
            if (answ==0) { ent = false; Console.Write("\b\b]");}
            else if (answ==1) { i = 0; si+=3;}
            else Console.WriteLine("Введено некорректное значение.");
        }
}
//string [] ray = {"hello", "2", "world", ":-("};
Console.WriteLine("");
Console.Write("[");
for(i = 0; i<ray.Length; i++)
{
    if (ray[i].Length<=3) { Console.Write(ray[i] + ", "); }
}
 Console.Write("\b\b]");