using Business.Business;
using Business.Dtos.Requists;
using Business.Dtos.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        //anatasyon Post=gönderi
        //ıoc konteynera eklemek
        private readonly IBrandService _brandservice;


        public BrandsController(IBrandService brandService)
        {
            _brandservice = brandService;
        }


        [HttpPost]
        public IActionResult Add(CreateBrandRequest createBrandRequest)
        {
           CreatedBrandPesponse createdBrandPesponse= _brandservice.Add(createBrandRequest);
           return Ok(createdBrandPesponse);
        }

        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_brandservice.GetAll());
        }

    }
}
