using System;
using System.Collections.Generic;
using System.Text;
using definitely_not_spotify.Models;

namespace definitely_not_spotify
{
    internal class TestData
    {
        public static List<Playlist> GetPlaylists(User user)
        {
            var rock = new Playlist("Rock Classics", user);
            rock.AddSong(new Song("Bohemian Rhapsody", Genre.Rock, "Queen"));
            rock.AddSong(new Song("Stairway to Heaven", Genre.Rock, "Led Zeppelin"));
            rock.AddSong(new Song("Hotel California", Genre.Rock, "Eagles"));

            var hiphop = new Playlist("Hip Hop Hits", user);
            hiphop.AddSong(new Song("Lose Yourself", Genre.HipHop, "Eminem"));
            hiphop.AddSong(new Song("Juicy", Genre.HipHop, "The Notorious B.I.G."));
            hiphop.AddSong(new Song("HUMBLE.", Genre.HipHop, "Kendrick Lamar"));

            var pop = new Playlist("Pop Favorites", user);
            pop.AddSong(new Song("Shape of You", Genre.Pop, "Ed Sheeran"));
            pop.AddSong(new Song("Blinding Lights", Genre.Pop, "The Weeknd"));
            pop.AddSong(new Song("Uptown Funk", Genre.Pop, "Bruno Mars"));

            var electronic = new Playlist("Electronic Vibes", user);
            electronic.AddSong(new Song("Wake Me Up", Genre.Electronic, "Avicii"));
            electronic.AddSong(new Song("Titanium", Genre.Electronic, "David Guetta"));
            electronic.AddSong(new Song("Clarity", Genre.Electronic, "Zedd"));

            return new List<Playlist> { rock, hiphop, pop, electronic };
        }
        public static List<User> GetUsers()
        {
            var bryan = new User("Bryan");
            bryan.Playlists.AddRange(GetPlaylists(bryan));

            return new List<User>
            {
                bryan,
                new User("Cas"),
                new User("Test")
            };
        }

        public static List<Song> GetSongs()
        {
            return new List<Song>
        {
            new Song("Somewhere I Belong", Genre.Rock, "Linkin Park"),
            new Song("In the End", Genre.Rock, "Linkin Park"),
            new Song("Numb", Genre.Rock, "Linkin Park"),
            new Song("Chop Suey!", Genre.Rock, "System of a Down"),
            new Song("Toxicity", Genre.Rock, "System of a Down"),
            new Song("The Pretender", Genre.Rock, "Foo Fighters"),
            new Song("Everlong", Genre.Rock, "Foo Fighters"),
            new Song("Californication", Genre.Rock, "Red Hot Chili Peppers"),
            new Song("By the Way", Genre.Rock, "Red Hot Chili Peppers"),
            new Song("Smells Like Teen Spirit", Genre.Rock, "Nirvana"),
            new Song("Come as You Are", Genre.Rock, "Nirvana"),
            new Song("Kryptonite", Genre.Rock, "3 Doors Down"),
            new Song("It's My Life", Genre.Rock, "Bon Jovi"),
            new Song("Bring Me to Life", Genre.Rock, "Evanescence"),
            new Song("Boulevard of Broken Dreams", Genre.Rock, "Green Day"),
            new Song("American Idiot", Genre.Rock, "Green Day"),
            new Song("Seven Nation Army", Genre.Rock, "The White Stripes"),
            new Song("Sex on Fire", Genre.Rock, "Kings of Leon"),
            new Song("How You Remind Me", Genre.Rock, "Nickelback"),
            new Song("Paralyzer", Genre.Rock, "Finger Eleven"),
            new Song("Lose Yourself", Genre.HipHop, "Eminem"),
            new Song("Without Me", Genre.HipHop, "Eminem"),
            new Song("Till I Collapse", Genre.HipHop, "Eminem"),
            new Song("In da Club", Genre.HipHop, "50 Cent"),
            new Song("Nuthin' But a 'G' Thang", Genre.HipHop, "Dr. Dre"),
            new Song("Still D.R.E.", Genre.HipHop, "Dr. Dre"),
            new Song("California Love", Genre.HipHop, "2Pac"),
            new Song("Juicy", Genre.HipHop, "The Notorious B.I.G."),
            new Song("Humble", Genre.HipHop, "Kendrick Lamar"),
            new Song("Alright", Genre.HipHop, "Kendrick Lamar"),
            new Song("God's Plan", Genre.HipHop, "Drake"),
            new Song("Hotline Bling", Genre.HipHop, "Drake"),
            new Song("Sicko Mode", Genre.HipHop, "Travis Scott"),
            new Song("SICKO MODE", Genre.HipHop, "Travis Scott"),
            new Song("Industry Baby", Genre.HipHop, "Lil Nas X"),
            new Song("Stronger", Genre.HipHop, "Kanye West"),
            new Song("Ni**as in Paris", Genre.HipHop, "JAY-Z"),
            new Song("Black and Yellow", Genre.HipHop, "Wiz Khalifa"),
            new Song("XO Tour Llif3", Genre.HipHop, "Lil Uzi Vert"),
            new Song("Rockstar", Genre.HipHop, "Post Malone"),
            new Song("Blinding Lights", Genre.Pop, "The Weeknd"),
            new Song("Starboy", Genre.Pop, "The Weeknd"),
            new Song("Shape of You", Genre.Pop, "Ed Sheeran"),
            new Song("Bad Habits", Genre.Pop, "Ed Sheeran"),
            new Song("As It Was", Genre.Pop, "Harry Styles"),
            new Song("Watermelon Sugar", Genre.Pop, "Harry Styles"),
            new Song("Stay", Genre.Pop, "The Kid LAROI"),
            new Song("Flowers", Genre.Pop, "Miley Cyrus"),
            new Song("Cruel Summer", Genre.Pop, "Taylor Swift"),
            new Song("Anti-Hero", Genre.Pop, "Taylor Swift"),
            new Song("Espresso", Genre.Pop, "Sabrina Carpenter"),
            new Song("Please Please Please", Genre.Pop, "Sabrina Carpenter"),
            new Song("Houdini", Genre.Pop, "Dua Lipa"),
            new Song("Levitating", Genre.Pop, "Dua Lipa"),
            new Song("Bad Guy", Genre.Pop, "Billie Eilish"),
            new Song("Birds of a Feather", Genre.Pop, "Billie Eilish"),
            new Song("Drivers License", Genre.Pop, "Olivia Rodrigo"),
            new Song("Good 4 U", Genre.Pop, "Olivia Rodrigo"),
            new Song("Uptown Funk", Genre.Pop, "Bruno Mars"),
            new Song("Die With A Smile", Genre.Pop, "Lady Gaga"),
            new Song("Wake Me Up", Genre.Electronic, "Avicii"),
            new Song("Levels", Genre.Electronic, "Avicii"),
            new Song("Titanium", Genre.Electronic, "David Guetta"),
            new Song("Don't You Worry Child", Genre.Electronic, "Swedish House Mafia"),
            new Song("Clarity", Genre.Electronic, "Zedd"),
            new Song("Lean On", Genre.Electronic, "Major Lazer"),
            new Song("Animals", Genre.Electronic, "Martin Garrix"),
            new Song("Scary Monsters and Nice Sprites", Genre.Electronic, "Skrillex"),
            new Song("Strobe", Genre.Electronic, "deadmau5"),
            new Song("Harder, Better, Faster, Stronger", Genre.Electronic, "Daft Punk"),
            new Song("One More Time", Genre.Electronic, "Daft Punk"),
            new Song("Intro", Genre.Electronic, "The xx"),
            new Song("Sail", Genre.Electronic, "AWOLNATION"),
            new Song("Midnight City", Genre.Electronic, "M83"),
            new Song("Alone", Genre.Electronic, "Marshmello"),
            new Song("Faded", Genre.Electronic, "Alan Walker"),
            new Song("Turn Down for What", Genre.Electronic, "DJ Snake"),
            new Song("Sad Machine", Genre.Electronic, "Porter Robinson"),
            new Song("Adagio for Strings", Genre.Electronic, "Tiësto"),
        };
        }
    }
}
