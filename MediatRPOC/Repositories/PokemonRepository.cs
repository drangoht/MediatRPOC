using MediatRPOC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatRPOC.Repositories
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly Dictionary<Guid, Pokemon> _pokemons = new();
        public async Task<Guid?> CreatePokemon(Pokemon pokemon)
        {
            if (_pokemons.ContainsKey(pokemon.PokemonId))
            {
                return null;
            }
            _pokemons[pokemon.PokemonId] = pokemon;
            return pokemon.PokemonId;
        }

        public async Task<Pokemon?> GetPokemon(Guid pokemonId)
        {
            if (!_pokemons.ContainsKey(pokemonId))
            {
                return null;
            }
            return _pokemons[pokemonId];
        }
    }
}
