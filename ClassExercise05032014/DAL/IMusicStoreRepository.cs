using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClassExercise05032014.Models;

namespace ClassExercise05032014.DAL
{
    public interface IMusicStoreRepository : IDisposable
    {
        IQueryable<Album> GetAllAlbums();
        IQueryable<Track> GetTracksByAlbumId(int id);
    }
}