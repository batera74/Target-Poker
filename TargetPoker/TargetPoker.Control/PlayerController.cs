using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TargetPoker.Control
{
    public class PlayerController
    {
        private Model.IDataPlayer _dataPlayer;

        public PlayerController()
        {
            this._dataPlayer = Container.FactoryData.GetPlayerRepository();
        }

        public PlayerController(Model.IDataPlayer dataPlayer)
        {
            this._dataPlayer = dataPlayer;
        }

        public void SavePlayer(Model.Player player)
        {
            if (player == null)
                throw new ArgumentNullException("_event");
            if (string.IsNullOrEmpty(player.Name))
                throw new InvalidOperationException("Name is empty");
            if (string.IsNullOrEmpty(player.Surname))
                throw new InvalidOperationException("Surname is empty");
            if (player.Birth == null)
                throw new InvalidOperationException("Birth is null");
            if (string.IsNullOrEmpty(player.Email))
                throw new InvalidOperationException("Email is empty");

            this._dataPlayer.Save(player);
        }

        public Model.Players GetAllPlayers()
        {
            return this._dataPlayer.GetAllPlayers();
        }

        public Model.Player GetPlayer(Guid id)
        {
            return this._dataPlayer.GetPlayer(id);
        }
    }
}
