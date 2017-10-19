using System;
using CustomerAppBLL;
using CustomerAppBLL.BusinessObjects;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace CustomerRestAPIi.Controllers
{
    [EnableCors("MyPolicy")]
    [Produces("application/json")]
    [Route("api/addresses")]
    public class AddressController : Controller
    {

        BLLFacade facade = new BLLFacade();

        [HttpPost]
        public IActionResult Post([FromBody]AddressBO address)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(facade.AddressService.Create(address));
        }
    }
}
