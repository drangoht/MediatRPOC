using MediatRPOC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatRPOC.Repositories
{
    public interface IPokemonRepository
    {
        Task<Guid?> CreatePokemon(Pokemon pokemon);
        Task<Pokemon?> GetPokemon(Guid pokemonId);
    }
}
