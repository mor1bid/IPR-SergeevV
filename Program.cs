void IPR()
{
    int i = 0;
    int si = 999;
    int ze = 0;
    string [] ar = new string [si];
    Console.WriteLine("Введите строки (для получения результата нажмите Enter): ");
    Console.WriteLine("[");
    void ProcessAr() 
    {
        bool ent = true;
        while (ent == true) 
        {
            string s = Convert.ToString(Console.ReadLine());
            ar[i] = s;
            string answ = "";
            ze++;
            i++;
            if (s==answ) {ent = false;}
        }
    }
    ProcessAr();
    Console.WriteLine("\b\b]");
    Console.Write("Строки, длина которых меньше/равна 3: [");
    void BuildAr() 
    {
        for(i = 0; i<ze; i++)
        {
            if (ar[i].Length<=3 && ar[i].Length!=0) { Console.Write(ar[i] + ", "); }
        }
    }
    BuildAr();
    Console.Write("\b\b]");
}
IPR();