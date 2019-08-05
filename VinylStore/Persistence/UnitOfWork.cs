using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VinylStore.Core;
using VinylStore.Core.Repositories;
using VinylStore.Dal;
using VinylStore.Persistence.Repositories;

namespace VinylStore.Persistence
{/// <summary>
 /// This unit of work is specific to our application
 /// so it recieves CustomMusicContext in its constructor and stores it in the private field-->[_context]
 /// it uses the same _context to initialise both the repositories
 /// Tracks = new TrackRepository(_context);
 /// ARTIST = new ArtistRepository(_context);-->it is not shown but could be shown in the same way
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        public ITrackRepository Tracks { get; private set; }

        protected readonly CustomMusicContext _context;
        public UnitOfWork(CustomMusicContext context)
        {
            this._context = context;
            Tracks = new TrackRepository(_context);
            // ARTIST = new ArtistRepository(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
