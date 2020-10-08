namespace EfCoreAutomapperOdata.Server.Data.Models
{
    public class FriendsRel
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int FriendId { get; set; }
        public Student Friend { get; set; }
    }
}