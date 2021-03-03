using System;
using OyunStoreProject.Abstract;
using OyunStoreProject.Entities;

namespace OyunStoreProject.Concrete
{
    public class PlayerManager:BasePlayerManager
    {
        public IPlayerCheckService _playerCheckService;

        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }

        public override void Buy(Player player, Game game)
        {
            
            if (_playerCheckService.CheckIfSeniorUser(player, game))
            {
                Console.WriteLine(game.GameName + " oyununu  " + game.Price+ " TL'ye satın aldı.");
            }
            else
            {
                Console.WriteLine(game.GameName + " oyununu  " + game.Price + " TL'ye satın aldı.");
            }
        }

        public override void Lend(Player player, Game game)
        {
            IPlayerCheckService _playerCheckService = new PlayerCheckManager();

            if (_playerCheckService.CheckIfSeniorUser(player, game))
            {
                Console.WriteLine(game.GameName + " oyununu  " + game.Price + " TL'ye satın aldı.");
            }
            else
            {
                Console.WriteLine(game.GameName + " oyununu  " + game.Price + " TL'ye kiraladı.");
            }

        }
    }
}
