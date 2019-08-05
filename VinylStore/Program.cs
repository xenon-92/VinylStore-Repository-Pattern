using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VinylStore.Dal;
using VinylStore.Persistence;

namespace VinylStore
{
    class Program
    {
        static void Main(string[] args)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork(new CustomMusicContext()))
            {
                //tracks with where artist id=1
                var tracks = unitOfWork.Tracks.GetTracksForArtist(1);
                //add new song to prevoius artist
                TRACK t = new TRACK()
                {
                    TRACK_NAME = "Comfortably numb",
                    TRACK_ARTIST = 3
                };
                unitOfWork.Tracks.Add(t);
                unitOfWork.Complete();
                var artist = unitOfWork.Tracks.Find(x => x.TRACK_ARTIST == 3).ToList();
            }
        }
    }
}
