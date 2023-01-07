using BusinessLogic;
using Microsoft.EntityFrameworkCore;

var dataServiceInstace = DataService.Instance;
var dbContext = dataServiceInstace.DatabaseContext;

dbContext.TaskTypes.Add(new BusinessLogic.DTO.TaskType("Cool task1", "Cool description1"));
dbContext.TaskTypes.Add(new BusinessLogic.DTO.TaskType("Cool task2", "Cool description2"));
dbContext.TaskTypes.Add(new BusinessLogic.DTO.TaskType("Cool task3", "Cool description3"));
dbContext.TaskTypes.Add(new BusinessLogic.DTO.TaskType("Cool task4", "Cool description4"));
dbContext.TaskTypes.Add(new BusinessLogic.DTO.TaskType("Cool task5", "Cool description5"));


dbContext.SaveChanges();
dbContext.TaskTypes.ForEachAsync(x => Console.WriteLine($"{x.Id} {x.Title}"));
