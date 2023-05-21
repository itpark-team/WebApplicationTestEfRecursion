using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationTestEfRecursion.Controllers;

[ApiController]
[Route("/test")]
public class TestController : ControllerBase
{
    private AlexTestJwtDbContext db;

    public TestController(AlexTestJwtDbContext db)
    {
        this.db = db;
    }

    [HttpGet]
    public List<WorkerDto> Get()
    {
        List<Worker> workers = db.Workers.Include(worker => worker.Positions).ToList();

        List<WorkerDto> workerDtos = new List<WorkerDto>();

        workers.ForEach(worker =>
        {
            WorkerDto workerDto = new WorkerDto()
            {
                Id = worker.Id,
                Name = worker.Name,
                Positions = new List<Position>(worker.Positions)
            };
            workerDtos.Add(workerDto);
        });

        return workerDtos;
    }
}