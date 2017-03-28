using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.IO;
using Newtonsoft.Json;
using SDTopSpotsAPI.Models;

namespace SDTopSpotsAPI.Controllers
{
    public class TopSpotsController : ApiController
    {

        [HttpGet, Route("api/topspots")]
        public IHttpActionResult GetTopSpots()
        {
            var topspots = File.ReadAllText("C:\\dev\\SDTopSpotsAPI\\topspots.json");
            TopSpot[] topSpotsArray = JsonConvert.DeserializeObject<TopSpot[]>(topspots);
            return Ok(topSpotsArray);
        }
    }
}