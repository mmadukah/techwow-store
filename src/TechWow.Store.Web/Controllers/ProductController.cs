using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using TechWow.Store.Core.Mappers.Abstractions;
using TechWow.Store.Core.Models;
using TechWow.Store.Services.Abstractions;
using TechWow.Store.Web.Models;

namespace TechWow.Store.Web.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductService _service;
        private readonly IReverseMapper<Product, ProductModel> _mapper;

        public ProductController(IProductService service, IReverseMapper<Product, ProductModel> mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add([FromBody]ProductModel model)
        {
            try
            {
                var domainModel = _mapper.Map(model);

                _service.Add(domainModel);

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex);
            }
        }

        [HttpPost]
        [Route("addMany")]
        public IActionResult AddMany([FromBody]IEnumerable<ProductModel> models)
        {
            try
            {
                var domainModels = _mapper.Map(models);

                _service.Add(domainModels);

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _service.Delete(id);

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex);
            }
        }

        [HttpGet("{id}")]
        [Route("get")]
        public IActionResult Get(int id)
        {
            try
            {
                var model = _service.Get(id);
                var dto = _mapper.Map(model);

                return Ok(dto);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex);
            }
        }

        [HttpGet]
        [Route("getAll")]
        public IActionResult GetAll()
        {
            try
            {
                var models = _service.GetAll();
                var dtos = _mapper.Map(models);

                return Ok(dtos);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex);
            }
        }

        [HttpPut]
        [Route("update")]
        public IActionResult Update([FromBody]ProductModel model)
        {
            try
            {
                var domainModel = _mapper.Map(model);

                _service.Update(domainModel);

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex);
            }
        }

        [HttpPut]
        [Route("updateMany")]
        public IActionResult UpdateMany([FromBody]IEnumerable<ProductModel> models)
        {
            try
            {
                var domainModels = _mapper.Map(models);

                _service.Update(domainModels);

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex);
            }
        }
    }
}
