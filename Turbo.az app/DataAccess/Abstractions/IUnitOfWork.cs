using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.az_app.DataAccess.Abstractions
{
    public interface IUnitOfWork
    {
        IBodyTypeRepository bodyTypeRepository { get; }
        IBrandRepository brandRepository { get; }
        ICarRepository carRepository { get; }
        ICityRepository cityRepository { get; }
        IColorRepository colorRepository { get; }
        IModelRepository modelRepository { get; }
        IStatusRepository statusRepository { get; }
    }
}
