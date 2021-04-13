using B.Models;
using BlazorAuction.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAuction.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BidController : ControllerBase
    {
        private readonly IBid_Repo _bid_Repo;
        public BidController(IBid_Repo _bid_Repo) => this._bid_Repo = _bid_Repo;

        [HttpGet]
        public async Task<ActionResult> GetBids()
        {
            try
            {
                return Ok(await _bid_Repo.GetBids());
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error. Nothing returned. " + e);
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Bid>> GetBid(int id)
        {
            try
            {
                var result = await _bid_Repo.GetBid(id);

                if (result == null)
                {
                    return NotFound();
                }

                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpPost]
        public async Task<ActionResult> CreateBid([FromBody] Bid bid)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {
                var newBid = await _bid_Repo.CreateBid(bid);

                return CreatedAtAction(nameof(GetBids),
                                        new { id = newBid.BidId }, newBid
                                        );
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error. Bid not added: " + e);
            }
        }
    }
    }
