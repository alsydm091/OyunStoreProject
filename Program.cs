using System;
using System.Collections.Generic;
using OyunStoreProject.Abstract;
using OyunStoreProject.Concrete;
using OyunStoreProject.Entities;

namespace OyunStoreProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region
            Game game1 = new Game("Far Cry 4", 100);
            Game game2 = new Game("Witcher 3", 200);
            
            Player player1 = new Player("Hacı Hüso", "Hüseyin", "Akdağ", 2020);
            Player player2 = new Player("Fişek Salih", "Salih", "Akkiraz", 2017);
            Player player3 = new Player("Deli Bayro", "Sinan", "Görkem", 2015);
            Player player4 = new Player("Davulcu Memo", "Davut", "Demir", 2010);
            Player player5 = new Player("Kılıç Ali", "Ali", "Demir", 0 );
            Player player6 = new Player("Mermi Hamza", "Hamza", "Demir", 0);

            


            BasePlayerManager managerIndirimli = new IndirimliPlayerManager(new PlayerCheckManager());
            BasePlayerManager managerNormal = new PlayerManager(new PlayerCheckManager());

            managerNormal.Lend(player6,game1);
            #endregion

            Console.WriteLine("---------------------------------------------------- ");
            Player[] players = { player1, player2, player3, player4, player5, player6 };
            foreach (Player player in players)
            {
                Console.WriteLine(player.Name+" "+player.LastName);
            }
        }
    }
    
    
}
