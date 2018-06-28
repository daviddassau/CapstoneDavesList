using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CapstoneDavesList.Services;

namespace CapstoneDavesList.Controllers
{
    [RoutePrefix("api/retailer")]
    public class RetailerController : ApiController
    {
        [HttpGet, Route("")]
        public HttpResponseMessage GetRetailers()
        {
            var retailerRepository = new RetailerRepository();
            var allRetailers = retailerRepository.GetAllRetailers();
        }
    }
}
