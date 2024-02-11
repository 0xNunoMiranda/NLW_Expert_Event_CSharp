using API.Communication.Requests;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    public class OfferController : AuctionBaseController
    {
        [HttpPost]
        [Route("{itemId}")]
        public IActionResult CreateOffer(
            [FromRoute] int itemId,
            [FromBody] RequestCreateOfferJson requestCreateOfferJson    
        )
        {
            return Ok(new Auction());
        }
    }
}
