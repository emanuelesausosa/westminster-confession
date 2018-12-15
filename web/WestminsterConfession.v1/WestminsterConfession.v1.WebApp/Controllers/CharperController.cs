using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WestminsterConfession.v1.Bussines.DTOs;
using WestminsterConfession.v1.Bussines.Managers;

namespace WestminsterConfession.v1.WebApp.Controllers
{
    [RoutePrefix("api/charper")]
    public class CharperController : ApiController
    {
        private readonly CharperManager _charperManager;
        public CharperController(CharperManager charperManager)
        {
            _charperManager = charperManager;
        }

        [HttpGet]
        [Route("all")]
        public async Task<IHttpActionResult> GetAllCharpers()
        {
            var result = await _charperManager.GetAllCharpers();
            return Ok(result);
        }

        [HttpPost]
        [Route("add-new")]
        public IHttpActionResult AddNewCharper()
        {
            try
            {
                var result = _charperManager.AddNewCharper(new DTOCharper
                {
                    NumberPosition = 1,
                    Resume = "this a resume",
                    RomanNumber = "I",
                    Title = "This is a first title"
                });


                Console.WriteLine("Charper record added: {0}", result);
                return Ok(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error to add {0}", ex.Message);
                return BadRequest();
            }
        }
    }
}
