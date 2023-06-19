using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Turbo.az_app.DataAccess.Abstractions;
using Turbo.az_app.DataAccess.Concrete;
using Turbo.az_app.Entities.Mapping;

namespace Turbo.az_app
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IUnitOfWork DB;
        public App()
        {
            DB = new UnitOfWork();

            DB.brandRepository.AddData(new Brand { BrandName = "Pagani" });
            DB.brandRepository.AddData(new Brand { BrandName = "Rolls Royce" });
            DB.brandRepository.AddData(new Brand { BrandName = "Lamborghini" });
            DB.brandRepository.AddData(new Brand { BrandName = "Bugatti" });

            DB.modelRepository.AddData(new Model { ModelName = "Huayra", BrandId = 1 });
            DB.modelRepository.AddData(new Model { ModelName = "Utopia", BrandId = 1 });
            DB.modelRepository.AddData(new Model { ModelName = "Zonda R", BrandId = 1 });
            DB.modelRepository.AddData(new Model { ModelName = "Imola", BrandId = 1 });
            DB.modelRepository.AddData(new Model { ModelName = "Phantom", BrandId = 2 });
            DB.modelRepository.AddData(new Model { ModelName = "Ghost", BrandId = 2 });
            DB.modelRepository.AddData(new Model { ModelName = "Cullinan", BrandId = 2 });
            DB.modelRepository.AddData(new Model { ModelName = "Huracan", BrandId = 3 });
            DB.modelRepository.AddData(new Model { ModelName = "Huracan EVO", BrandId = 3 });
            DB.modelRepository.AddData(new Model { ModelName = "Aventador", BrandId = 3 });
            DB.modelRepository.AddData(new Model { ModelName = "Urus", BrandId = 3 });
            DB.modelRepository.AddData(new Model { ModelName = "Chiron", BrandId = 4 });
            DB.modelRepository.AddData(new Model { ModelName = "Veyron", BrandId = 4 });
            DB.modelRepository.AddData(new Model { ModelName = "Divo", BrandId = 4 });
            DB.modelRepository.AddData(new Model { ModelName = "Centodieci", BrandId = 4 });

            DB.bodyTypeRepository.AddData(new BodyType { BodyTypeName = "Coupe" });
            DB.bodyTypeRepository.AddData(new BodyType { BodyTypeName = "Sedan" });
            DB.bodyTypeRepository.AddData(new BodyType { BodyTypeName = "SUV" });

            DB.cityRepository.AddData(new City { CityName = "Baku" });
            DB.cityRepository.AddData(new City { CityName = "Sumgait" });
            DB.cityRepository.AddData(new City { CityName = "Shaki" });
            DB.cityRepository.AddData(new City { CityName = "Ganja" });
            DB.cityRepository.AddData(new City { CityName = "Nakhchivan" });

            DB.colorRepository.AddData(new Color { ColorName = "Red" });
            DB.colorRepository.AddData(new Color { ColorName = "Green" });
            DB.colorRepository.AddData(new Color { ColorName = "Blue" });

            DB.statusRepository.AddData(new Status { IsNew = true });
            DB.statusRepository.AddData(new Status { IsNew = true });

            //DB.carRepository.AddData(new Car
            //{
            //      ModelId=1,
            //});
        }
    }
}
