using InterviewWorld.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InterviewWorld.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        //private readonly InterviewWorldDBContext _dbContext;
        //public SubjectController(InterviewWorldDBContext dbContext)
        //{
        //    _dbContext = dbContext ;
        //}



        [HttpGet("GetStringData")]
        public string GetStringData()
        {
            return "Sachin";
        }
    }
}
