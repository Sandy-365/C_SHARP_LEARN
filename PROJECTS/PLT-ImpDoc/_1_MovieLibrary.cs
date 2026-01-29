using System;
using System.Collections.Generic;

namespace MovieLibrary
{
    interface IFilm
    {
        string Title { get; set; }
        string Director { get; set; }
        int Year { get; set; }
    }

    class Film : IFilm
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }
    }

    interface IFilmLibrary
    {
        void AddFilm(IFilm film);
        void RemoveFilm(string title);
        List<IFilm> GetFilms();
        List<string> SearchFilms(string query);
        int GetTotalFilmCount();
    }

    class FilmLibrary : IFilmLibrary
    {
        private List<IFilm> _films = new List<IFilm>();

        public void AddFilm(IFilm film)
        {
            _films.Add(film);
        }

        public void RemoveFilm(string title)
        {
            for (int i = 0; i < _films.Count; i++)
            {
                if (_films[i].Title == title)
                {
                    _films.RemoveAt(i);
                    return;
                }
            }
        }

        public List<IFilm> GetFilms()
        {
            return _films;
        }

        public List<string> SearchFilms(string query)
        {
            List<string> result = new List<string>();

            for (int i = 0; i < _films.Count; i++)
            {
                if (_films[i].Title.Contains(query) || _films[i].Director.Contains(query))
                {
                    result.Add(_films[i].Title);
                }
            }

            return result;
        }

        public int GetTotalFilmCount()
        {
            return _films.Count;
        }
    }
}
