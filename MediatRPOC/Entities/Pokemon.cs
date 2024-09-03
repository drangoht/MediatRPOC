using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatRPOC.Entities
{

    public class Pokemon
    {
        public Guid PokemonId { get; set; }
        public string PokemonName { get; set; } = string.Empty;
        public string PokemonDescription { get; set; } = string.Empty;
        public int PokemonStrength { get; set; }
        public int PokemonHealth { get; set; }
    }
}