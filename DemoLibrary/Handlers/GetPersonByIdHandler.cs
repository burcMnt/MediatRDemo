using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class GetPersonByIdHandler : IRequestHandler<GetPersonByIdQuery, PersonModel>
    {
        private readonly IDataAccess _data;

        public GetPersonByIdHandler(IDataAccess data)
        {
            _data = data;
        }
        public Task<PersonModel> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.GetById(request.Id));
        }




        //DataAccess e yeni bir metot tanımlamadan {GetById gibi} GetPeople() üzerinden Id çekme 

        //private readonly IMediator _mediator;
        //public GetPersonByIdHandler(IMediator mediator)
        //{
        //   _mediator = mediator;
        //}

        //public async Task<PersonModel> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
        //{
        //    var result = await _mediator.Send(new GetPersonListQuery());
        //    var output = result.FirstOrDefault(x => x.Id == request.Id);
        //    return output;
        //}
    }
}
