using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using ClassExercise05032014.Models;

namespace ClassExercise05032014.DAL
{
    public class MusicStoreContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Track> Tracks { get; set; }

        public MusicStoreContext()
            : base("MusicStoreDatabase")
        {
            //Database.SetInitializer(new MusicStoreInitializer());
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //}

    }

    //public class MusicStoreInitializer : DropCreateDatabaseIfModelChanges<MusicStoreContext>
    //{
    //    protected override void Seed(MusicStoreContext context)
    //    {
    //        var albums = new List<Album> 
    //        {
    //            new Album{AlbumName="1st Album"},
    //            new Album{AlbumName="2st Album"},
    //            new Album{AlbumName="3st Album"},
    //            new Album{AlbumName="4st Album"},
    //            new Album{AlbumName="5st Album"},
    //        };
    //        albums.ForEach(a =>context.Albums.Add(a));
    //        context.SaveChanges();
    //        var tracks = new List<Track> 
    //        {
    //            new Track{AlbumId=1, TrackName="Track 1"},
    //            new Track{AlbumId=1, TrackName="Track 2"},
    //            new Track{AlbumId=1, TrackName="Track 3"},
    //            new Track{AlbumId=1, TrackName="Track 4"},
    //            new Track{AlbumId=1, TrackName="Track 5"},

    //            new Track{AlbumId=2, TrackName="Song 1"},
    //            new Track{AlbumId=2, TrackName="Song 2"},
    //            new Track{AlbumId=2, TrackName="Song 3"},
    //            new Track{AlbumId=2, TrackName="Song 4"},
    //            new Track{AlbumId=2, TrackName="Song 5"},

    //            new Track{AlbumId=3, TrackName="Music 1"},
    //            new Track{AlbumId=3, TrackName="Music 2"},
    //            new Track{AlbumId=3, TrackName="Music 3"},
    //            new Track{AlbumId=3, TrackName="Music 4"},
    //            new Track{AlbumId=3, TrackName="Music 5"},

    //            new Track{AlbumId=4, TrackName="Sound 1"},
    //            new Track{AlbumId=4, TrackName="Sound 2"},
    //            new Track{AlbumId=4, TrackName="Sound 3"},
    //            new Track{AlbumId=4, TrackName="Sound 4"},
    //            new Track{AlbumId=4, TrackName="Sound 5"},

    //            new Track{AlbumId=5, TrackName="Yeahhh 1"},
    //            new Track{AlbumId=5, TrackName="Yeahhh 2"},
    //            new Track{AlbumId=5, TrackName="Yeahhh 3"},
    //            new Track{AlbumId=5, TrackName="Yeahhh 4"},
    //            new Track{AlbumId=5, TrackName="Yeahhh 5"},
    //        };

    //        tracks.ForEach(t=>context.Tracks.Add(t));
    //        context.SaveChanges();  
    //    }
    //}
}