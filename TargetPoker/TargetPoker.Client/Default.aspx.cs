using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TargetPoker.Model;
using TargetPoker.Control;

namespace TargetPoker.Client
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            List<Entidades.Evento> eventos = new List<Evento>();
            Entidades.Evento evento = new Evento() { Data = "20/10", Descricao = "Esse evento é um teste. Não deixe de conferir!" };
            Entidades.Evento evento2 = new Evento() { Data = "18/10", Descricao = "Esse evento é um teste. Não deixe de conferir!" };
            Entidades.Evento evento3 = new Evento() { Data = "10/10", Descricao = "Esse evento é um teste. Não deixe de conferir!" };
            Entidades.Evento evento4 = new Evento() { Data = "05/10", Descricao = "Esse evento é um teste. Não deixe de conferir!" };
            eventos.Add(evento);
            eventos.Add(evento2);
            eventos.Add(evento3);
            eventos.Add(evento4);

            rptEventos.DataSource = eventos;*/

            PlayerController playerController = new PlayerController();
            var x = playerController.GetAllPlayers();

            Model.Player player = new Player();
            player.Name = "Guilherme";
            player.Surname = "Andrade";
            player.TargetTeam = true;
            player.Email = "guilherme.andrade@outlook.com";
            player.Birth = new DateTime(1990, 12, 22);
            
            playerController.SavePlayer(player);
        }
    }
}
