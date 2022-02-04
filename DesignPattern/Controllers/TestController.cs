using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AyaatLibrary.ResponseModel;
using Services.Interface;

namespace DesignPattern.Controllers
{
    [Produces("application/json")]
    [Route("api/Test")]
    public class TestController : ControllerBase
    {
        private readonly IMyFirstService _myFirstService;

        public TestController(IMyFirstService myFirstService)
        {
            _myFirstService = myFirstService;
        }

        [HttpGet]
        [Route("TestApi")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> TestApi()
        {
            var response = new SingleResponseModel<dynamic>();
            try
            {
                var data = await _myFirstService.TestApi();
                response.Model = data;
            }
            catch(Exception ex)
            {
                response.DidError = true;
                response.ErrorMessage = ex.Message.ToString();
            }
            return response.ToHttpResponse();
        }
    }
}
