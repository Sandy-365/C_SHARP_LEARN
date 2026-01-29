class Program
{
    static void Main(string[] args)
    {
        FilmLibrary library = new FilmLibrary();

        library.AddFilm(new Film { Title = "Inception", Director = "Christopher Nolan", Year = 2010 });
        library.AddFilm(new Film { Title = "Interstellar", Director = "Christopher Nolan", Year = 2014 });

        Console.WriteLine(library.GetTotalFilmCount());

        List<string> found = library.SearchFilms("Nolan");
        for (int i = 0; i < found.Count; i++)
            Console.WriteLine(found[i]);

        library.RemoveFilm("Inception");
        Console.WriteLine(library.GetTotalFilmCount());

        List<IFilm> films = library.GetFilms();
        for (int i = 0; i < films.Count; i++)
            Console.WriteLine(films[i].Title + " " + films[i].Director + " " + films[i].Year);
    }
}