using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Queries
{
    public record GetPersonListQuery() : IRequest<List<PersonModel>>;

    //record and this below class equivalent eachother except the fact that a record has the additional syntax and goodness that records provide such as being immutable by default
    //public class GetPersonListQueryClass : IRequest<List<PersonModel>>
    //{
    //}
  
}
