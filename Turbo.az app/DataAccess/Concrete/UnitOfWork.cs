using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.az_app.DataAccess.Abstractions;

namespace Turbo.az_app.DataAccess.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        public IBodyTypeRepository bodyTypeRepository => new EFBodyTypeRepository();

        public IBrandRepository brandRepository =>new EFBrandRepository();

        public ICarRepository carRepository => new EFCarRepository(); 

        public ICityRepository cityRepository => new EFCityRepository();

        public IColorRepository colorRepository => new EFColorRepository();

        public IModelRepository modelRepository =>new EFModelRepository();

        public IFuelTypeRepository fuelTypeRepository => new EFFuelTypeRepository();
    }
}
