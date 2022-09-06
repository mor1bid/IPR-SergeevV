string [] ray = {"hello", "2", "world", ":-("};
Console.Write("[");
for(int i = 0; i<ray.Length; i++)
{
    if (ray[i].Length<=3) { Console.Write(ray[i] + ", "); }
}
Console.Write("\b\b]");