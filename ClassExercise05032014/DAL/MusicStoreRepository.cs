using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassExercise05032014.DAL
{
    public class MusicStoreRepository : IMusicStoreRepository
    {
        private MusicStoreContext _ctx;

        public MusicStoreRepository()
        {
            _ctx = new MusicStoreContext();
        }

        public IQueryable<Models.Album> GetAllAlbums()
        {
            return _ctx.Albums;
        }

        public IQueryable<Models.Track> GetTracksByAlbumId(int id)
        {
            return _ctx.Tracks.Where(t=>t.AlbumId == id);
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }
    }
}