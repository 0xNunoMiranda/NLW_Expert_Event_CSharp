using API.Entities;
using API.UseCases.Auctions.GetCurrent;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    public class AuctionController : AuctionBaseController
    {
        [HttpGet]
        [ProducesResponseType(typeof(Auction), StatusCodes.Status200OK)]
        public IActionResult GetCurrentAuction()
        {
            var useCase = new GetCurrentAuctionUseCase();
            var result = useCase.Execute();
            if (result is null) return NoContent();
            return Ok(result);
        }
    }


}
