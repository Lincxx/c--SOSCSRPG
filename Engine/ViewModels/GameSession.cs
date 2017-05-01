using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.ViewModels
{
    class GameSession
    {
        //Property 
        Player CurrentPlayer { get; set; }

        //constructor 
        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Jeremy";
            CurrentPlayer.Gold = 1000000;
        }
    }
}
