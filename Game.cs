using System;

public class Game {
    public string Title;
    public string Genre;
    public int ReleaseYear;
    public double Rating;

    public Game(string title, string genre) {
        Title = title;
        Genre = genre;
        ReleaseYear = 2026;
        Rating = 0.0;
    }
    public void UpdateRating(double newRating) {
        if (newRating < 0.0 || newRating > 10.0) {
            return;
        }

        Rating = newRating;
    }
}