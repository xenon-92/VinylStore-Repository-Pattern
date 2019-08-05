using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VinylStore.Dal;

namespace VinylStore.Core.Repositories
{
    public interface ITrackRepository:IRepository<TRACK>
    {
        IEnumerable<TRACK> GetTracksForArtist(int id);
    }
}
