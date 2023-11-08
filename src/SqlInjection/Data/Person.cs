namespace SqlInjection.Data;

public class Person
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public ICollection<Movie>? DirectedMovies { get; set; }
}
