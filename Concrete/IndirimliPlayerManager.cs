using System;
using OyunStoreProject.Abstract;
using OyunStoreProject.Entities;

namespace OyunStoreProject.Concrete
{
    public class IndirimliPlayerManager : BasePlayerManager
    {
        public IPlayerCheckService _playerCheckService; // Ampulden initialize field from constroctor seçildi.

        public IndirimliPlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }

        public override void Buy(Player player, Game game)
        {
            if (_playerCheckService.CheckIfSeniorUser(player, game))
            {
                Console.WriteLine(player.UserName + " aldı kullanıcı "
               + game.GameName + " oyununu %30 indirim ile " + (game.Price = (game.Price * 70 / 100))
              + " TL'ye satın aldı. Kayıt Tarihi: " + player.EntryTime);
            }
            else
            {
                Console.WriteLine(player.UserName + " aldı kullanıcı "
                 + game.GameName + " oyununu %15 indirim ile " + (game.Price = (game.Price * 85 / 100))
                 + " TL'ye satın aldı. Kayıt Tarihi: " + player.EntryTime);
            }

        }

        public override void Lend(Player player, Game game)
        {
            if (_playerCheckService.CheckIfSeniorUser(player, game))
            {
                Console.WriteLine(player.UserName + " aldı kullanıcı "
                 + game.GameName + " oyununu %50 indirim ile " + (game.Price = (game.Price * 50 / 100))
                 + "TL'ye kiraladı. Kayıt Tarihi: " + player.EntryTime);
            }
            else
            {
                Console.WriteLine(player.UserName + " aldı kullanıcı "
                + game.GameName + " oyununu %30 indirim ile " + (game.Price = (game.Price * 70 / 100))
                 + "TL'ye kiraladı. Kayıt Tarihi: " + player.EntryTime);
            }
        }
    }
    
}
