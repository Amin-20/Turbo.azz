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

            DB.brandRepository.AddData(new Brand { BrandName = "Lada" });
            DB.brandRepository.AddData(new Brand { BrandName = "BMW" });
            DB.brandRepository.AddData(new Brand { BrandName = "Mercedes" });
            DB.brandRepository.AddData(new Brand { BrandName = "Kia" });

            DB.modelRepository.AddData(new Model { ModelName = "Niva", BrandId = 1 });
            DB.modelRepository.AddData(new Model { ModelName = "2107", BrandId = 1 });
            DB.modelRepository.AddData(new Model { ModelName = "Priora", BrandId = 1 });
            DB.modelRepository.AddData(new Model { ModelName = "M5", BrandId = 2 });
            DB.modelRepository.AddData(new Model { ModelName = "X5", BrandId = 2 });
            DB.modelRepository.AddData(new Model { ModelName = "I8", BrandId = 2 });
            DB.modelRepository.AddData(new Model { ModelName = "G55 AMG", BrandId = 3 });
            DB.modelRepository.AddData(new Model { ModelName = "E 250", BrandId = 3 });
            DB.modelRepository.AddData(new Model { ModelName = "S 450 4Matic", BrandId = 3 });
            DB.modelRepository.AddData(new Model { ModelName = "GLE 450", BrandId = 3 });
            DB.modelRepository.AddData(new Model { ModelName = "Optima", BrandId = 4 });
            DB.modelRepository.AddData(new Model { ModelName = "K5", BrandId = 4 });
            DB.modelRepository.AddData(new Model { ModelName = "Ceed", BrandId = 4 });
            DB.modelRepository.AddData(new Model { ModelName = "Cerato", BrandId = 4 });

            DB.bodyTypeRepository.AddData(new BodyType { BodyTypeName = "Coupe" });
            DB.bodyTypeRepository.AddData(new BodyType { BodyTypeName = "Sedan" });
            DB.bodyTypeRepository.AddData(new BodyType { BodyTypeName = "SUV" });

            DB.cityRepository.AddData(new City { CityName = "Baku" });
            DB.cityRepository.AddData(new City { CityName = "Sumgait" });
            DB.cityRepository.AddData(new City { CityName = "Ganja" });
            DB.cityRepository.AddData(new City { CityName = "Nakhchivan" });

            DB.colorRepository.AddData(new Color { ColorName = "Red" });
            DB.colorRepository.AddData(new Color { ColorName = "Green" });
            DB.colorRepository.AddData(new Color { ColorName = "Blue" });

        }
    }
}
