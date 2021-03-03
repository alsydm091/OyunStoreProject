using OyunStoreProject.Entities;

namespace OyunStoreProject.Abstract
{
    public interface IPlayerService
    {
        void Buy(Player player, Game game);
        void Lend(Player player, Game game);

    }
}
