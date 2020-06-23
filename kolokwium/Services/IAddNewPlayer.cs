using kolokwium.DTO;
using kolokwium.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium.Services
{
    interface IAddNewPlayer
    {

        public Player_Team addToTeam(int IdTeam, NewPlayerDTO player);
    }
}
