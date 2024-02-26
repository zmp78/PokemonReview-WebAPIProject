namespace PokemonReview.Dto
{
    // data transport objects (DTOs) play a crucial role in exchanging information between different layers of an application, such as between a client and a server, and traditionally, developers have used classes to define DTOs, which involves writing boilerplate code for properties, constructors, comparison methods, and string representations.
   // dto makes sure that you don't return all your data and helps you limit the data you have in your model.
    public class PokemonDto
    {
        // this is part of the Pokemon Model that we want to return it:
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
