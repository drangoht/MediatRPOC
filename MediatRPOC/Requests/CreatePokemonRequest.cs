using MediatR;
using MediatRPOC.Entities;

namespace MediatRPOC.Requests
{
    public class CreatePokemonRequest : IRequest<Guid?>
    {
        public Pokemon Pokemon { get; set; }
    }

}
