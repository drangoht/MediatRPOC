using MediatR;
using MediatRPOC.Entities;
using MediatRPOC.Repositories;
using MediatRPOC.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatRPOC.Handlers
{
    public class GetPokemonHandler : IRequestHandler<GetPokemonRequest, Pokemon?>
    {
        private readonly IPokemonRepository _pokemonRepository;

        public GetPokemonHandler(IPokemonRepository pokemonRepository)
        {
            _pokemonRepository = pokemonRepository;
        }

        public async Task<Pokemon?> Handle(GetPokemonRequest request, CancellationToken cancellationToken)
        {
            return await _pokemonRepository.GetPokemon(request.PokemonId);
        }
    }
}
