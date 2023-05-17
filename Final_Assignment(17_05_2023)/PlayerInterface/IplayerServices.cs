using Day9_Interface_17_05_2023_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Interface_17_05_2023_.PlayerInterface
{
    public interface IplayerServices
    {

        void Create(PlayerDetails player);
        List<PlayerDetails> ReadAll();
        PlayerDetails ReadById(int id);
        void Update(PlayerDetails player);
        void Delete(int id);



    }
}
