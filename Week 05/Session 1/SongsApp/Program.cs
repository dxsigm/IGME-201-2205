using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsApp
{
    /////[+ISong|Name:string;Play();Sing();Dance();Copy()]
    public interface ISong
    {
        string Name
        {
            get; set;
        }

        void Play();
        void Sing();
        void Dance();
        void Copy();

    }
    /////[+IPlay|Name:string;Play()]
    public interface IPlay
    {
        string Name
        {
            get; set;
        }

        void Play();
    }

    /////[+A:Song|+year:int;+lyrics:string;+composer:string;+artist:string|+Name:string;+Play():a;+Copy():v;+Dance();+Sing()]

    public abstract class Song : ISong, IPlay
    {
        public int year;
        public string lyrics;
        public string composer;
        public string artist;
        public string Name
        {
            get; set;
        }

        public abstract void Play();

        public virtual void Copy()
        {
            // default copy method is for analog copying
            // play the song through the device and record it with our phone
        }

        public void Dance()
        {
            // bust a move
        }

        public void Sing()
        {
            // lalala
        }
    }


    /////[+TapeSong|+tapeName:string;+side:int;+counter:int|+Play():o]
    public class TapeSong : Song
    {
        public string tapeName;
        public int side;
        public int counter;
        public override void Play()
        {
            // load the cassette on the right side
            // fast forward to counter
            // press play
        }
    }

    /////[+VinylSong|+recordName:string;+side:int;+track:int|+Play():o;+Clean()]
    public class VinylSong : Song
    {
        public string recordName;
        public int side;
        public int track;
        public override void Play()
        {
            // turn on the turntable
            // put the record on the record player on the right side
            // drop the needle on the correct track
        }

        public void Clean()
        {
            // clean the record
        }
    }


    /////[+CDSong|+cdName:string;+track:int|+Play():o]
    public class CDSong : Song
    {
        public string cdName;
        public int track;
        public override void Play()
        {
            // insert cd
            // forward to track
            // press play
        }
    }
    ///
    /////[+MP3Song|+fileName:string|+Play():o;+Copy():o]
    public class MP3Song : Song
    {
        public string fileName;

        public override void Play()
        {
            // insert cd
            // forward to track
            // press play
        }

        public override void Copy()
        {
            // copy and paste the mp3 file
        }
    }

    /////
    /////[+Game|+players:int|+Name:string;+Play()]
    /////
    public class Game : IPlay
    {
        public int players;
        public string Name
        {
            get; set;
        }

        public void Play()
        {
            // play the game
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TapeSong tapeSong = new TapeSong();

            tapeSong.Name = "Happy";

            CDSong cdSong = new CDSong();
            cdSong.Name = "Bridge Over Troubled Waters";

            List<Song> songList = new List<Song>();
            songList.Add(cdSong);
            songList.Add(tapeSong);

            SortedList<string, object> songGameSortedList = new SortedList<string, object>();
            songGameSortedList[tapeSong.Name] = tapeSong;
            songGameSortedList[cdSong.Name] = cdSong;
            songGameSortedList["david"] = "david schuh";

            Game chess = new Game();
            chess.Name = "chess";
            songGameSortedList[chess.Name] = chess;

            chess.Play();
            tapeSong.Play();

            PlayThisObject(chess);
            PlayThisObject(tapeSong);

            VinylSong vinylSong = new VinylSong();
            vinylSong.Name = "Suite Judy Blue Eyes";
            PlayThisObject(vinylSong);

            CDSong thisCDSong = (CDSong)songGameSortedList["Happy"];
            object thisObj = thisCDSong;

            thisCDSong = (CDSong)thisObj;
        }

        public static void PlayThisObject(object obj)
        {
            if (obj.GetType() == typeof(VinylSong))
            {
                VinylSong vinylSong;

                vinylSong = (VinylSong)obj;
                vinylSong.Clean();
            }

            IPlay iPlay;
            iPlay = (IPlay)obj;
            iPlay.Play();

            if (obj.GetType() == typeof(VinylSong) ||
                obj.GetType() == typeof(TapeSong) ||
                obj.GetType() == typeof(MP3Song) ||
                obj.GetType() == typeof(CDSong))
            {
                Song song;
                song = (Song)obj;
                song.Dance();
            }
        }
    }
}
