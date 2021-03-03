using OyunStoreProject.Entities;

namespace OyunStoreProject.Abstract
{
    public interface IPlayerCheckService
    {
        bool CheckIfSeniorUser(Player player, Game game);
    }
}
