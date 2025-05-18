using LogSheet_API.Common;
using LogSheet_API.Repository;
using LogSheet_API.VMMOdels;
using Microsoft.AspNetCore.Mvc;
using System.CodeDom;

namespace LogSheet_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolutionController : Controller
    {
        private readonly ISolution _solution;

        public SolutionController(ISolution solution)
        {
            this._solution = solution;
        }

        [HttpPost]
        [Route("getSolutions")]
        public async Task<IActionResult> getSolutions()
        {

            TransactionalInformation transaction = new TransactionalInformation();
            try
            {
                var solution = await _solution.getSolutions();
                transaction.ReturnStatus = true;    
                return Ok(new { solution, transaction });
            }
            catch(Exception ex)
            {
                transaction.ReturnStatus = false;
                transaction.ReturnMessage = new List<string>();
                string errormessage=ex.Message.ToString();
                transaction.ReturnMessage.Add(errormessage);

                Log.WriteLog("SolutionController", "getSolutions",  "Error", errormessage);
                return BadRequest(new { transaction });

            }
        }


        //[HttpPost]
        //[Route("getSolutionById")]
        //public async Task<IActionResult> getSolutionById()
        //{
        //    try
        //    {
        //        return  Ok("API Working ");
        //    }
        //    catch
        //    {

        //    }
            
        //}

        //[HttpPost]
        //[Route("savandupdatesolution")]
        //public async Task<IActionResult> savandupdatesolution()
        //{
        //    try
        //    {
        //        return Ok("API Working ");
        //    }
        //    catch
        //    {

        //    }
            
        //}



    }
}
