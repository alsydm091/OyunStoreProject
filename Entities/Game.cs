namespace OyunStoreProject.Entities
{
    public class Game
    {
        public Game(string gameName, int price)
        {
            GameName = gameName;
            Price = price;
        }

        public string GameName { get; set; }
        public int Price { get; set; }
    }

    
}