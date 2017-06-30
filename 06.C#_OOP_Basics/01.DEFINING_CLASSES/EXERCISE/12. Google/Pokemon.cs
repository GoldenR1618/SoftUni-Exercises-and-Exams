using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Pokemon
{
    private string pokemonName;
    private string pokemonType;

    public string PokemonName { get { return this.pokemonName; } set { this.pokemonName = value; } }
    public string PokemonType { get { return this.pokemonType; } set { this.pokemonType = value; } }
}
