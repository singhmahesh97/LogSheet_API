using LogSheet_API.Common;
using LogSheet_API.DTOs;
using LogSheet_API.Repository;
using LogSheet_API.VMMOdels;
using Microsoft.AspNetCore.Mvc;

namespace LogSheet_API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : Controller
    {
        private readonly IClient _client;


        public ClientController(IClient client)
        {
            _client = client;
        }

        [HttpPost]
        [Route("getClients")]
        public async Task<IActionResult> getClients()
        {

            TransactionalInformation transaction = new TransactionalInformation();
            try
            {
                var Clinet = await _client.GetClients();
                transaction.ReturnStatus = true;
                return Ok(new { Clinet, transaction });
            }
            catch (Exception ex)
            {
                transaction.ReturnStatus = false;
                transaction.ReturnMessage = new List<string>();
                string errormessage = ex.Message.ToString();
                transaction.ReturnMessage.Add(errormessage);

                Log.WriteLog("ClientController", "getClient", "Error", errormessage);
                return BadRequest(new { transaction });

            }
        }


        [HttpPost]
        [Route("getClientById")]
        public async Task<IActionResult> getClientById([FromForm] ClientDtoByID ClientDtoByID)
        {

            TransactionalInformation transaction = new TransactionalInformation();
            try
            {
                var Client = await _client.GetClientById(ClientDtoByID);
                transaction.ReturnStatus = true;
                return Ok(new { Client, transaction });
            }
            catch (Exception ex)
            {
                transaction.ReturnStatus = false;
                transaction.ReturnMessage = new List<string>();
                string errormessage = ex.Message.ToString();
                transaction.ReturnMessage.Add(errormessage);

                Log.WriteLog("ClientController", "getClients", "Error", errormessage);
                return BadRequest(new { transaction });

            }

        }



        [HttpPost("saveandupdateClient")]
        public async Task<IActionResult> SaveAndUpdateClient([FromBody] SaveUpdateClientDto dto)
        {

            TransactionalInformation transaction = new TransactionalInformation();
            try
            {
                var result = await _client.SaveAndUpdateClient(dto);
                if (result == null)
                    return NotFound(new { message = "Client not found." });

                return Ok(result);
            }
            catch (Exception ex)
            {
                transaction.ReturnStatus = false;
                transaction.ReturnMessage = new List<string>();
                string errormessage = ex.Message.ToString();
                transaction.ReturnMessage.Add(errormessage);

                Log.WriteLog("ClientController", "saveandupdateClient", "Error", errormessage);
                return BadRequest(new { transaction });
            }
        }


    }
}
