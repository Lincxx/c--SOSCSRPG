﻿using System;
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
        public Location CurrentLocation { get; set; }
        public World CurrentWorld { get; set; }

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

            CurrentLocation = new Location();
            CurrentLocation.Name = "Home";
            CurrentLocation.XCoordinate = 0;
            CurrentLocation.YCoordinate = -1;
            CurrentLocation.Description = "This is your house";
            CurrentLocation.ImageName = "/Engine;component/Images/Locations/Home.png";

            CurrentWorld = new World();
        }
    }
}
