using OyunStoreProject.Abstract;
using OyunStoreProject.Entities;

namespace OyunStoreProject.Concrete
{
    public class PlayerCheckManager: IPlayerCheckService
    {
        public bool CheckIfSeniorUser(Player player, Game game)
        {
            if (player.EntryTime < 2016 && player.EntryTime != 0)
            {
                return true;
            }
            else
            {
                return false;   
            }
        }
    }
}
