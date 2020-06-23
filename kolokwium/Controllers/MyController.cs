using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kolokwium.DTO;
using kolokwium.Models;
using kolokwium.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace kolokwium.Controllers
{
  //  [Route("api/[controller]")]
    [ApiController]
    public class MyController : ControllerBase
    {
        MyContext context;

        public MyController(MyContext context)
        {
            this.context = context;
        }

       
        [HttpGet("api/championships/{IdChampionships}/teams")]
        public IActionResult getTeamScore(int IdChampionships)
        {
            try
            {
                return Ok(context.GetService<ITeamsChampionshipsService>().getTeams(IdChampionships));
            } catch (MyException e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpPost("api/teams/{IdTeam}/players")]
        public IActionResult addNewPlayer (int IdTeam, NewPlayerDTO player)
        {
            try
            {
                return Ok(context.GetService<IAddNewPlayer>().addToTeam(IdTeam, player));
            }
            catch (MyException e) { return NotFound(e.Message); };

        } 
    }
}