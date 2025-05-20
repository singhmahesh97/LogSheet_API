using LogSheet_API.Common;
using LogSheet_API.DTOs;
using LogSheet_API.Models;
using LogSheet_API.Repository;
using LogSheet_API.VMMOdels;
using Microsoft.AspNetCore.Mvc;


namespace LogSheet_API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class LogSheetController : Controller
    {
        private readonly ILogSheet _logSheet;

        public LogSheetController(ILogSheet logSheet)
        {
            _logSheet = logSheet;
        }

        [HttpPost]
        [Route("getLogSheet")]
        public async Task<IActionResult> getLogSheet()
        {
            TransactionalInformation transaction = new TransactionalInformation();
            try
            {
                var logSheet = await _logSheet.GetLogSheets();
                transaction.ReturnStatus = true;
                return Ok(new { logSheet, transaction });
            }
            catch (Exception ex)
            {
                transaction.ReturnStatus = false;
                transaction.ReturnMessage = new List<string>();
                string errormessage = ex.Message.ToString();
                transaction.ReturnMessage.Add(errormessage);
                Log.WriteLog("LogSheetController", "getLogSheet", "Error", errormessage);
                return BadRequest(new { transaction });
            }
        }


        [HttpPost]
        [Route("getlogSheetById")]
        public async Task<IActionResult> getlogSheetById([FromForm] LogSheetDtoByID logSheetDtoBy)
        {

            TransactionalInformation transaction = new TransactionalInformation();
            try
            {
                var logSheet = await _logSheet.GetLogSheetById(logSheetDtoBy);
                transaction.ReturnStatus = true;
                return Ok(new { logSheet, transaction });
            }
            catch (Exception ex)
            {
                transaction.ReturnStatus = false;
                transaction.ReturnMessage = new List<string>();
                string errormessage = ex.Message.ToString();
                transaction.ReturnMessage.Add(errormessage);

                Log.WriteLog("LogSheetController", "getCLogSheet", "Error", errormessage);
                return BadRequest(new { transaction });

            }
        }

        [HttpPost("saveandupdateLogSheet")]
        public async Task<IActionResult> SaveAndUpdateLogSheet([FromBody] SaveUpdateLogSheetDto dto)
        {

            TransactionalInformation transaction = new TransactionalInformation();
            try
            {
                var result = await _logSheet.SaveAndUpdateLogSheet(dto);
                if (result == null)
                    return NotFound(new { message = "LogSheet not found." });

                return Ok(result);
            }
            catch (Exception ex)
            {
                transaction.ReturnStatus = false;
                transaction.ReturnMessage = new List<string>();
                string errormessage = ex.Message.ToString();
                transaction.ReturnMessage.Add(errormessage);

                Log.WriteLog("LogSheetController", "SaveAndUpdateLogSheet", "Error", errormessage);
                return BadRequest(new { transaction });
            }
        }

    }

}
