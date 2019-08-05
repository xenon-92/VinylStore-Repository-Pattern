using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VinylStore.Core.Repositories;
using VinylStore.Dal;

namespace VinylStore.Persistence.Repositories
{
    public class TrackRepository : Repository<TRACK>, ITrackRepository
    {
        public TrackRepository(CustomMusicContext customMusicContext):base(customMusicContext)
        {

        }
        public IEnumerable<TRACK> GetTracksForArtist(int id)
        {
            return CustomMusicContext.TRACKs.Where(i => i.TRACK_ARTIST == id).ToList();
        }
        public CustomMusicContext CustomMusicContext
        /*
        This property is of type CustomMusicContext,all we are doing is casting the Context that we are inheriting from the 
        generic repsoitory ie base of this class -->[Repository<TRACK>], we are casting that to pluto context
        */
        {
            get { return Context as CustomMusicContext; }
        }
    }
}
