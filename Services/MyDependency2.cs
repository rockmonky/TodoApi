using TodoApi.Interfaces;

namespace TodoApi;

public class MyDependency2 : IMyDependency
{
    private readonly ILogger<MyDependency2> _logger;

    public MyDependency2(ILogger<MyDependency2> logger)
    {
        _logger = logger;
    }


    public void WriteMessage(string message)
    {
        System.Console.WriteLine(message);
        _logger.LogInformation($"MyDependency2.WriteMessage called. Message: {message}");
    }



}
