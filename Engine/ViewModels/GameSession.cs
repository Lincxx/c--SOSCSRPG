using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession
    {
        //Property 
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocaton { get; set; }

        //constructor 
        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Jeremy";
            CurrentPlayer.CharacterClass = "Fighter";
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.Gold = 1000000;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;

            CurrentLocaton = new Location();
            CurrentLocaton.Name = "Home";
            CurrentLocaton.XCoordinate = 0;
            CurrentLocaton.YCoordinate = -1;
            CurrentLocaton.Description = "This is your house.";
        }
    }
}
