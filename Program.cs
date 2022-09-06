int [] ar = new int [] {1111, 1, 11111, 111};
string [] ray = {"hello", "2", "world", ":-("};
Console.Write("[");
for(int i = 0; i<ar.Length; i++)
{
    int co = 0;
    int num = ar[i];
    while (num!=0)
    {
        co++;
        num/=10;
    }
    if (co<=3) { Console.Write(ray[i] + ", "); }
}
Console.Write("\b\b]");