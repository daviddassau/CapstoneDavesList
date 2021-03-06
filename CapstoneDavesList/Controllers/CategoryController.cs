﻿using System;
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

            return Request.CreateResponse(HttpStatusCode.OK, allCategories);
        }

        [HttpGet, Route("{id}")]
        public HttpResponseMessage GetSingleCategory(int id)
        {
            var categoryRepository = new CategoryRepository();
            var singleCategory = categoryRepository.GetSingleCategory(id);

            return Request.CreateResponse(HttpStatusCode.OK, singleCategory);
        }
    }
}
