using MediatR;
using MediatRPOC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatRPOC.Requests
{
    public class GetPokemonRequest : IRequest<Pokemon?>
    {
        public Guid PokemonId { get; set; }
    }
}
