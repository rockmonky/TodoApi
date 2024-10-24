using TodoApi.Interfaces;

namespace TodoApi.Services;

public class MyDependency : IMyDependency
{
    public void WriteMessage(string message)
    {
        Console.WriteLine(message);
    }

}
