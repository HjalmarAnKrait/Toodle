using BusinessLogic;
using BusinessLogic.DTO;
using BusinessLogic.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

var dataServiceInstace = DataService.Instance;
var dbContext = new DatabaseContext();

var lol = dataServiceInstace.TaskTypeRepository;

lol.AddOrUpdate(new TaskType("Cool task", "Cool description1"));
lol.AddOrUpdate(new TaskType("Cool task2", "Cool description1") {
    ActiveDaysEnum = BusinessLogic.Enums.ActiveDaysEnum.WEEKEND});
lol.AddOrUpdate(new TaskType("Cool task3", "Cool description1")
{
    ActiveDaysEnum = BusinessLogic.Enums.ActiveDaysEnum.WORK_DAYS
});
var kek = dataServiceInstace.TaskRecordRepository;

kek.CreateTasksOnDay();
Console.WriteLine(Directory.GetCurrentDirectory());
