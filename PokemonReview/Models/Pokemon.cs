namespace PokemonReview.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<Review> Reviews { get; set;} //One-To-Many Relation
        public ICollection<PokemonCategory> PokemonCategories { get; set; } //Many-To-Many Relaition
        public ICollection<PokemonOwner> PokemonOwners { get; set; } //Many-To-Many Relaition

    }
}
