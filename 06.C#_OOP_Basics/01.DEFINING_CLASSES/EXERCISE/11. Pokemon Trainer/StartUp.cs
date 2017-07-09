using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StartUp
{
    public static void Main()
    {
        List<Trainer> listOfTrainers = new List<Trainer>();

        string input = Console.ReadLine();

        while (input != "Tournament")
        {
            string[] args = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string trainerName = args[0];
            string pokemonName = args[1];
            string pokemonElement = args[2];
            double pokemonHealth = double.Parse(args[3]);

            Pokemon currPokemon = new Pokemon
            {
                Name = pokemonName,
                Element = pokemonElement,
                Health = pokemonHealth
            };

            bool isContainsThisTrainer = false;

            if (listOfTrainers.Count > 0)
            {
                isContainsThisTrainer = listOfTrainers.Any(x => x.Name == trainerName);
            }
            
            if (!isContainsThisTrainer) //Ако няма такъв тренер.
            {
                List<Pokemon> currListOfPokemon = new List<Pokemon>
                {
                    currPokemon
                };

                Trainer currTrainer = new Trainer
                {
                    Name = trainerName,
                    NumberOfBadges = 0,
                    ListOfPokemons = currListOfPokemon
                };

                listOfTrainers.Add(currTrainer);
            }
            else    //Ако има такъв тренер.
            {
                Trainer thisTrainer = listOfTrainers.Where(x => x.Name == trainerName).First();

                thisTrainer.ListOfPokemons.Add(currPokemon);
            }

            input = Console.ReadLine();
        }

        string input2 = Console.ReadLine();

        while (input2 != "End")
        {
            foreach (var trainer in listOfTrainers)
            {
                if (trainer.ListOfPokemons.Any(x => x.Element == input2))    //Тренера има покемон с такъв елемент
                {
                    trainer.NumberOfBadges++; //Бадж++
                }
                else    //Няма такъв покемон.
                {
                    //Всички покемони губят 10 здраве.
                    for (int i = 0; i < trainer.ListOfPokemons.Count; i++)
                    {
                        trainer.ListOfPokemons[i].Health -= 10;

                        if (trainer.ListOfPokemons[i].Health <= 0)   //Ако покемона е умрял се маха.
                        {
                            trainer.ListOfPokemons.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }

            input2 = Console.ReadLine();
        }

        foreach (var trainer in listOfTrainers.OrderByDescending(x => x.NumberOfBadges))
        {
            Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.ListOfPokemons.Count}");
        }
    }
}
