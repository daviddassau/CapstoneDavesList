using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CapstoneDavesList.Services;

namespace CapstoneDavesList.Controllers
{
    [RoutePrefix("api/category")]
    public class CategoryController : ApiController
    {
        [HttpGet, Route("")]
        public HttpResponseMessage GetCategories()
        {
            var categoryRepository = new CategoryRepository();
            var allCategories = categoryRepository.GetAllCategories();
        }
    }
}
