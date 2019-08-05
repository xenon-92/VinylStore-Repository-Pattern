using Rough.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rough
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicContext mc = new MusicContext();
            TRACK t = new TRACK()
            {
                TRACK_NAME = "Man who sold is ferrari",
                TRACK_ARTIST = 3
            };
            mc.TRACKs.Add(t);
            mc.SaveChanges();
        }
    }
}
