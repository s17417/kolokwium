using kolokwium.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium.Services
{
    interface ITeamsChampionshipsService
    {
        public IEnumerable<TeamChampionshipsDTO> getTeams(int IdChampionships);
    }
}
