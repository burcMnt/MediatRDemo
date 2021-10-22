using DemoLibrary.Commands;
using DemoLibrary.DTOs;
using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PersonController(IMediator mediator)
        {
            _mediator = mediator;
        }


        // GET: api/<PersonController>
        [HttpGet]
        public async
            Task<List<PersonModel>> Get()
        {
            var list=  await _mediator.Send(new GetPersonListQuery());
            return list;
        }

        // GET api/<PersonController>/1
        [HttpGet("{id}")]
        public Task<PersonModel> Get(int id)
        {
            return _mediator.Send(new GetPersonByIdQuery(id));
        }

        // POST api/<PersonController>
        [HttpPost]
        public Task<PersonModel> Post([FromBody]InsertPersonDto person)
        {
            return _mediator.Send(new InsertPersonCommand(person.FirstName,person.LastName));
        }

        // DELETE api/<PersonController>/2
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _mediator.Send(new DeletePersonCommand(id));
        }
    }
}
