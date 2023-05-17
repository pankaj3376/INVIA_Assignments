using System;
using System.Collections.Generic;
using Day9_Interface_17_05_2023_.Models;
using Day9_Interface_17_05_2023_.PlayerInterface;

namespace Day9_Interface_17_05_2023_.PlayerServices
{
    public class playerServices: IplayerServices
    {
        private List<PlayerDetails> players;

        public playerServices()
        {
            players = new List<PlayerDetails>();
        }

        public void Create(PlayerDetails player)
        {
            players.Add(player);
        }

        public List<PlayerDetails> ReadAll()
        {
            return players;
        }

        public PlayerDetails ReadById(int id)
        {
            return players.Find(p => p.Id == id);
        }

        public void Update(PlayerDetails updatedPlayer)
        {
            PlayerDetails player = players.Find(p => p.Id == updatedPlayer.Id);
            if (player != null)
            {
                player.Name = updatedPlayer.Name;
                player.Age = updatedPlayer.Age;
            }
            else
            {
                Console.WriteLine("Person not found!");
            }
        }

        public void Delete(int id)
        {
            PlayerDetails player = players.Find(p => p.Id == id);
            if (player != null)
            {
                players.Remove(player);
            }
            else
            {
                Console.WriteLine("Person not found!");
            }
        }

        public void notTODisplay()
        {
            Console.WriteLine("this function not for Display");
        }
    }
}
