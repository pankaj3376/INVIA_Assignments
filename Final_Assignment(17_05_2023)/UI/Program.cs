using System;
using System.Collections.Generic;
using Day9_Interface_17_05_2023_.Models;
using Day9_Interface_17_05_2023_.PlayerServices;
using Day9_Interface_17_05_2023_.PlayerInterface;

namespace Day9_Interface_17_05_2023_.UI
{
    public class Program
    {
        private static IplayerServices playrService = new playerServices();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Add player");
                Console.WriteLine("2. Display all players List");
                Console.WriteLine("3. Read player by ID");
                Console.WriteLine("4. Update player");
                Console.WriteLine("5. Delete player");
                Console.WriteLine("6. Exit\n");
                Console.WriteLine("Enter your choice:");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CreatePlayer();
                        break;
                    case 2:
                        ReadAllPlayer();
                        break;
                    case 3:
                        ReadPlayerById();
                        break;
                    case 4:
                        UpdatePlayer();
                        break;
                    case 5:
                        DeletePlayer();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }

        private static void CreatePlayer()
        {
            Console.WriteLine("Enter player ID:");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter player name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter player game:");
            string game = Console.ReadLine();
            Console.WriteLine("Enter player age:");
            int age = Convert.ToInt32(Console.ReadLine());

            PlayerDetails player = new PlayerDetails { Id = id, Name = name,Game = game, Age = age };
            playrService.Create(player);

            ////playrService.notTODisplay();

            Console.WriteLine("Person created successfully!");
        }

        private static void ReadAllPlayer()
        {
            var players = playrService.ReadAll();

            if (players.Count == 0)
            {
                Console.WriteLine("No persons found!");
            }
            else
            {
                foreach (var player in players)
                {
                    Console.WriteLine($"ID: {player.Id}, Name: {player.Name}, Game: {player.Game}, Age: {player.Age}");
                }
            }
        }

        private static void ReadPlayerById()
        {
            Console.WriteLine("Enter person ID:");
            int id = Convert.ToInt32(Console.ReadLine());

            PlayerDetails player = playrService.ReadById(id);

            if (player != null)
            {
                Console.WriteLine($"ID: {player.Id}, Name: {player.Name},Game: {player.Game}, Age: {player.Age}");
            }
            else
            {
                Console.WriteLine("Person not found!");
            }
        }

        private static void UpdatePlayer()
        {
            Console.WriteLine("Enter person ID:");
            int id = Convert.ToInt32(Console.ReadLine());

            PlayerDetails existingPlayer = playrService.ReadById(id);

            if (existingPlayer != null)
            {
                Console.WriteLine("Enter updated player name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter updated player game:");
                string game = Console.ReadLine();

                Console.WriteLine("Enter updated player age:");
                int age = Convert.ToInt32(Console.ReadLine());

                PlayerDetails updatedPlayer = new PlayerDetails { Id = id, Name = name, Game = game, Age = age };
                playrService.Update(updatedPlayer);

                Console.WriteLine("Player updated successfully!");
            }
            else
            {
                Console.WriteLine("Player not found!");
            }
        }

        private static void DeletePlayer()
        {
            Console.WriteLine("Enter player ID:");
            int id = Convert.ToInt32(Console.ReadLine());

            playrService.Delete(id);

            Console.WriteLine("Player deleted successfully!");
        }
    }
}
