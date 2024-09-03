using MediatR;
using MediatRPOC.Repositories;
using MediatRPOC.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatRPOC.Handlers
{
    public class CreatePokemonHandler : IRequestHandler<CreatePokemonRequest, Guid?>
    {
        //Inject Validators 
        private readonly IPokemonRepository _pokemonRepository;

        public CreatePokemonHandler(IPokemonRepository customerRepository)
        {
            _pokemonRepository = customerRepository;
        }

        public async Task<Guid?> Handle(CreatePokemonRequest request,
            CancellationToken cancellationToken)
        {
            // First validate the request
            return await _pokemonRepository.CreatePokemon(request.Pokemon);
        }
    }
}
