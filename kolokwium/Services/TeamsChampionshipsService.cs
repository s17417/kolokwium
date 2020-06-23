using kolokwium.DTO;
using kolokwium.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium.Services
{
    public class TeamsChampionshipsService : ITeamsChampionshipsService
    {
        MyContext context;

        public TeamsChampionshipsService(MyContext context)
        {
            this.context = context;
        }

        public IEnumerable<TeamChampionshipsDTO> getTeams(int IdChampionships)
        {
            if (context.Championships.Find(IdChampionships) == null) throw new MyException("brak zawodów o takim ID!!!!");
            var zawody = (from ch_team in context.Championship_Teams
                          join team in context.Teams on ch_team.IdTeam equals team.IdTeam
                          where ch_team.IdChampionship == IdChampionships
                          select new TeamChampionshipsDTO
                          {
                              TeamName = team.TeamName,
                              Score = ch_team.Score
                          }).OrderBy(item => item.Score).ToList();
            return zawody;
        }
    }
}
