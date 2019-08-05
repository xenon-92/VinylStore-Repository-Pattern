using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VinylStore.Core.Repositories;

namespace VinylStore.Core
{/// <summary>
/// Inherits from IDisposable and exposes all the custom dbSets 
/// note that all the type are of Interfaces
/// </summary>
    public interface IUnitOfWork:IDisposable
    {
        ITrackRepository Tracks { get; }
        int Complete();
    }
}
