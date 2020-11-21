using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_sample.Models;
using api_sample.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_sample.Controllers
{
    [Route("api/person")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        [Route("list")]
        public IActionResult ListAllPerson()
        {
            List<PersonModel> persons = _personService.ListAllPerson();
            return Ok(persons);
        }
    }
}