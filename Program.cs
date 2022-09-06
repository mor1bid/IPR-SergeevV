int [] ar = new int [] {1111, 1, 11111, 111};
//string [] ray = new string [] {hello, 1, 11111, 111};
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
    if (co<=3) { Console.Write(ar[i] + ", "); }
}
Console.Write("\b\b]");