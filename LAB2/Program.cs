using MinDLL;
using System.Reflection;
Assembly asm = Assembly.LoadFrom("MinDLL.dll");
Type? t = asm.GetType("Class1");
if (t is not null)
{
    object? obj = Activator.CreateInstance(t);
    MethodInfo? min = t.GetMethod("Min", BindingFlags.NonPublic | BindingFlags.Static);
    object? result = min?.Invoke(obj, new object[] { 10 });
    Console.WriteLine(result);
}
else
{
    Class1 minDLL = new Class1();
    minDLL.Min(10);
}
