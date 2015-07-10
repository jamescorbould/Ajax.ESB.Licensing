using Ajax.ESB.Licensing.WebStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ajax.ESB.Licensing.WebStore.Controllers
{
    public class GiftController : ApiController
    {
        Gift[] gifts = new Gift[] 
        { 
            new Gift { Id = 0, Name = "External HDD 1TB" }, 
            new Gift { Id = 1, Name = "Teddy bear" }, 
            new Gift { Id = 2, Name = "Fish shaped object" },
            new Gift { Id = 3, Name = "Apple" }, 
            new Gift { Id = 4, Name = "Orange" }, 
            new Gift { Id = 5, Name = "Banana" },
            new Gift { Id = 6, Name = "Watch" }, 
            new Gift { Id = 7, Name = "SOA Patterns book" }, 
            new Gift { Id = 8, Name = "Aftershave" },
            new Gift { Id = 9, Name = "$10 voucher" }
        };

        public IHttpActionResult GetGift()
        {
            Random random = new Random();

            var gift = gifts.FirstOrDefault((p) => p.Id == random.Next(0, 10));
            if (gift == null)
            {
                return NotFound();
            }
            return Ok(gift);
        }
    }
}
