using System.Runtime.CompilerServices;

namespace Interceptors;
public static class Interceptor
{
    [InterceptsLocation(@"C:\Users\patry\source\repos\C#12Demo\Interceptors\Interceptors.cs", 6, 9)]
    public static void MyInterceptor(this Example example, string word)
    {
        Console.WriteLine($"Hello, this was intercepted. Word: {word}");
    }
}
