using kolokwium.DTO;
using kolokwium.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium.Services
{
    public class AddNewPlayer : IAddNewPlayer
    {
        MyContext context;

        public AddNewPlayer(MyContext context)
        {
            this.context = context;
        }

        public Player_Team addToTeam(int IdTeam, NewPlayerDTO player)
        {
            Team team = context.Teams.Find(IdTeam);
            if (team == null) throw new MyException("Brak takiej druzyny");

            Player databasePlayer = (from plr in context.Players
                                     where plr.FirstName == player.firstName && plr.LastName == player.lastName && plr.DateOfBirth.Equals(player.birthdate)
                                     select new Player
                                     {
                                         IdPlayer = plr.IdPlayer,
                                         DateOfBirth=plr.DateOfBirth,
                                         FirstName=plr.FirstName,
                                         LastName=plr.LastName
                                     }).First();
            if (databasePlayer == null) throw new MyException("Gracza nie ma w bazie");
            if ((DateTime.Today.Year - databasePlayer.DateOfBirth.Year) > team.MaxAge) throw new MyException("Gracz za stary");

            if (context.Player_Teams.Any(item => item.IdPlayer == databasePlayer.IdPlayer)) throw new MyException("gracz juz jest przypisany");

            Player_Team player_team = new Player_Team()
            {
                Player = databasePlayer,
                Team = team,
                NumOfShirt = player.numOnShirt,
                Comment = player.Comment
            };

                context.Player_Teams.Add(player_team);
            context.SaveChanges();
            return player_team;
        }
    }
}
