namespace OyunStoreProject.Entities
{
    public class Player
    {
        public Player(string userName, string name, string lastName, int entryTime)
        {
            UserName = userName;
            Name = name;
            LastName = lastName;
            EntryTime = entryTime;
        }

        public string UserName { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int EntryTime { get; set; }

        
    }
}