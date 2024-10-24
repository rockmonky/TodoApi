<!-- Create and open a new API Rest project -->
# dotnet new webapi --use-controllers -o <name-project>
# cd <name-project>
# dotnet add package Microsoft.EntityFrameworkCore.InMemory
# code -r ../<name-project>


<!-- Configuration -->
# dotnet dev-certs https --trust --> Use Https.
# dotnet run --launch-profile https --> Launch application.

<!-- Incorporation a Model class -->
## Add a folder and inside file that represent
# namespace TodoApi.Models;
# public class TodoItem
# {
#     public long Id { get; set; }
#     public string? Name { get; set; }
#     public bool IsComplete { get; set; }
# }



<!-- Incorporation a Db Context to com -->