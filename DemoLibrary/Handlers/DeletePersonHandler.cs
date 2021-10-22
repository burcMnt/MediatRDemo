using DemoLibrary.Commands;
using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class DeletePersonHandler : IRequestHandler<DeletePersonCommand>
    {
        private readonly IDataAccess _data;

        public DeletePersonHandler(IDataAccess data)
        {
            _data = data;
        }

        public Task<Unit> Handle(DeletePersonCommand request, CancellationToken cancellationToken)
        {
            _data.DeletePerson(request.id);
            return null;
        }
    }
}
