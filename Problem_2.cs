using System;
using System.Security.Permissions;

public class Movie
{
    public string title;
    public string director;
    public int year;
    public decimal rating;
    public Movie next;
    public Movie prev;

    public Movie()
    {
        this.title = "";
        this.director = "";
        this.year = 0;
        this.rating = 0;
        this.next = null;
        this.prev = null;
    }

    public Movie(string title, string director, int year, decimal rating)
    {
        this.title = title;
        this.director = director;
        this.year = year;
        this.rating = rating;
        this.next = null;
        this.prev = null;
    }
}

public class MovieList
{
    private Movie head;
    private Movie tail;

    public void AddMovieAtBeginning(Movie newMovie)
    {
        newMovie.next = head;
        head = newMovie;
        Console.WriteLine("Movie added successfully");
    }

    public void AddMovieAtEnd(Movie newMovie)
    {
        if (head == null)
        {
            head = newMovie;
            tail = newMovie;
        }
        else
        {
            tail.next = newMovie;
            newMovie.prev = tail;
            tail = newMovie;
        }
        Console.WriteLine("Movie added successfully");
    }

    public void AddMovieAtPosition(Movie newMovie, int position)
    {
        if (position == 1)
        {
            AddMovieAtBeginning(newMovie);
        }
        else
        {
            Movie temp = head;
            for (int i = 1; i < position - 1 && temp != null; i++)
            {
                temp = temp.next;
            }
            if (temp == null)
            {
                Console.WriteLine("Invalid position");
            }
            else
            {
                newMovie.next = temp.next;
                newMovie.prev = temp;
                temp.next = newMovie;
                if (newMovie.next != null)
                {
                    newMovie.next.prev = newMovie;
                }
                Console.WriteLine("Movie added successfully");
            }
        }
    }

    public void DeleteMovieByTitle(string title)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty");
        }
        else if (head.title == title)
        {
            head = head.next;
            if (head != null)
            {
                head.prev = null;
            }
        }
        else
        {
            Movie temp = head;
            while (temp.next != null && temp.next.title != title)
            {
                temp = temp.next;
            }
            if (temp.next == null)
            {
                Console.WriteLine("Movie not found");
            }
            else
            {
                temp.next = temp.next.next;
                if (temp.next != null)
                {
                    temp.next.prev = temp;
                }
            }
        }
    }

    public void SearchMovieByDirector(string director)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty");
        }
        else
        {
            Movie temp = head;
            bool found = false;
            while (temp != null)
            {
                if (temp.director == director)
                {
                    Console.WriteLine("Title: " + temp.title);
                    Console.WriteLine("Director: " + temp.director);
                    Console.WriteLine("Year: " + temp.year);
                    Console.WriteLine("Rating: " + temp.rating);
                    found = true;
                }
                temp = temp.next;
            }
            if (!found)
            {
                Console.WriteLine("No movies found for director " + director);
            }
        }
    }

    public void SearchMovieByRating(decimal rating)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty");
        }
        else
        {
            Movie temp = head;
            bool found = false;
            while (temp != null)
            {
                if (temp.rating == rating)
                {
                    Console.WriteLine("Title: " + temp.title);
                    Console.WriteLine("Director: " + temp.director);
                    Console.WriteLine("Year: " + temp.year);
                    Console.WriteLine("Rating: " + temp.rating);
                    found = true;
                }
                temp = temp.next;
            }
            if (!found)
            {
                Console.WriteLine("No movies found with rating " + rating);
            }
        }
    }

    public void UpdateRatingByTitle(string title, decimal rating)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty");
        }
        else
        {
            Movie temp = head;
            bool found = false;
            while (temp != null)
            {
                if (temp.title == title)
                {
                    temp.rating = rating;
                    Console.WriteLine("Rating updated successfully");
                    found = true;
                    break;
                }
                temp = temp.next;
            }
            if (!found)
            {
                Console.WriteLine("Movie not found");
            }
        }
    }

    public void DisplayMovies()
    {
        if (head == null)
        {
            Console.WriteLine("List is empty");
        }
        else
        {
            Movie temp = head;
            while (temp != null)
            {
                Console.WriteLine("Title: " + temp.title);
                Console.WriteLine("Director: " + temp.director);
                Console.WriteLine("Year: " + temp.year);
                Console.WriteLine("Rating: " + temp.rating);
                temp = temp.next;
            }
        }
    }

    public void DisplayMovieInReverse()
    {
        if (head == null)
        {
            Console.WriteLine("List is empty");
        }
        else
        {
            Movie temp = tail;
            while (temp != null)
            {
                Console.WriteLine("Title: " + temp.title);
                Console.WriteLine("Director: " + temp.director);
                Console.WriteLine("Year: " + temp.year);
                Console.WriteLine("Rating: " + temp.rating);
                temp = temp.prev;
            }
        }
    }
}

public class Program
{
    public static void Main()
    {
        MovieList movieList = new MovieList();

        Movie movie1 = new Movie("The Shawshank Redemption", "Frank Darabont", 1994, 9.3m);
        Movie movie2 = new Movie("The Godfather", "Francis Ford Coppola", 1972, 9.2m);
        Movie movie3 = new Movie("The Dark Knight", "Christopher Nolan", 2008, 9.0m);
        Movie movie4 = new Movie("Avengers: Endgame", "Anthony Russo", 2019, 8.4m);
        Movie movie5 = new Movie("Inception", "Christopher Nolan", 2010, 8.8m);
        Movie movie6 = new Movie("Pulp Fiction", "Quentin Tarantino", 1994, 8.9m);

        movieList.AddMovieAtEnd(movie1);
        movieList.AddMovieAtEnd(movie2);
        movieList.AddMovieAtBeginning(movie3);
        movieList.AddMovieAtPosition(movie4, 2);
        movieList.AddMovieAtPosition(movie5, 3);
        movieList.AddMovieAtPosition(movie6, 4);

        movieList.DisplayMovies();
        movieList.DisplayMovieInReverse();

        movieList.DeleteMovieByTitle("The Dark Knight");
        movieList.DisplayMovies();

        movieList.SearchMovieByDirector("Christopher Nolan");
        movieList.SearchMovieByRating(8.8m);

        movieList.UpdateRatingByTitle("The Godfather", 9.5m);


    }
}
