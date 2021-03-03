using System;
using OyunStoreProject.Entities;

namespace OyunStoreProject.Abstract
{
    public abstract  class BasePlayerManager:IPlayerService
    {

        public virtual void Buy(Player player, Game game)
        {
           
        }

        public virtual void Lend(Player player, Game game)
        {
            

        }
    }
}
