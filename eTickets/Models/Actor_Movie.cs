namespace eTickets.Models
{
    public class Actor_Movie
    {
        public int Movie_Id { get; set; }

        public Movie Movie { get; set; }
        public int Actor_Id { get; set; }

        public Actor Actor { get; set; }
    }
}
