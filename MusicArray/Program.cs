using System;
namespace musicArray
{
    class Program
    {
        enum Genre
        {
            Classic,
            Alternative,
            Metal,
            Jazz,
            Pop
        }

        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private decimal Length;
            private Genre? Genre;


            public void setTitle(string title)
            {
                Title = title;
            }
            public void setArtist(string artist)
            {
                Artist = artist;
            }

            public void setAlbum(string album)
            {
                Album = album;
            }
            
            public void setLength(decimal length)
            {
                Length = length;
            }
            public void setGenre(Genre? genre)
            {
                Genre = genre;
            }

            public string Display()
            {
                return "Title: " + Title + "\nArtist: " + Artist +
                    "\nAlbum: " + Album + "\nLength: " + Length + "\nGenre: " + Genre;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("How many songs would you like to enter?");
            int size = int.Parse(Console.ReadLine());
            Music[] collection = new Music[size];
            try
            {

                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("Please enter the song title");
                    collection[i].setTitle(Console.ReadLine());
                    Console.WriteLine("Who is the artist?");
                    collection[i].setArtist(Console.ReadLine());
                    Console.WriteLine("What is the name of the album?");
                    collection[i].setAlbum(Console.ReadLine());
                    Console.WriteLine("What is the length of the track?");
                    collection[i].setLength (decimal.Parse(Console.ReadLine()));
                    Console.WriteLine("What is the music genre?");

                    Console.WriteLine("C - classic\nM - metal\nA - alternative\nJ - jazz\nP - pop");

                    Genre tempGenre = Genre.Classic;

                    char g = char.Parse(Console.ReadLine());

                    switch (g)

                    {

                        case 'C':

                            tempGenre = Genre.Classic;

                            break;

                        case 'M':

                            tempGenre = Genre.Metal;

                            break;

                        case 'A':

                            tempGenre = Genre.Alternative;

                            break;

                        case 'J':

                            tempGenre = Genre.Jazz;

                            break;

                        case 'P':

                            tempGenre = Genre.Pop;

                            break;

                    }

                    collection[i].setGenre(tempGenre);


                }
                }

            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {

                for (int i = 0; i < size; i++)
                    Console.WriteLine($"{collection[i].Display()}");
            }

        }

    }
}
