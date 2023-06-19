using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Turbo.az_app.DataAccess.Abstractions;
using Turbo.az_app.DataAccess.Concrete;
using Turbo.az_app.Entities;
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

            //BRAND
            DB.brandRepository.AddData(new Brand { BrandName = "Lada" });      //1
            DB.brandRepository.AddData(new Brand { BrandName = "BMW" });       //2
            DB.brandRepository.AddData(new Brand { BrandName = "Mercedes" });  //3
            DB.brandRepository.AddData(new Brand { BrandName = "Kia" });       //4
            DB.brandRepository.AddData(new Brand { BrandName = "Toyota" });    //5

            //MODEL
            DB.modelRepository.AddData(new Model { ModelName = "Niva", BrandId = 1 });          //1
            DB.modelRepository.AddData(new Model { ModelName = "2107", BrandId = 1 });          //2
            DB.modelRepository.AddData(new Model { ModelName = "Priora", BrandId = 1 });        //3
            DB.modelRepository.AddData(new Model { ModelName = "M5", BrandId = 2 });            //4
            DB.modelRepository.AddData(new Model { ModelName = "X5", BrandId = 2 });            //5
            DB.modelRepository.AddData(new Model { ModelName = "I8", BrandId = 2 });            //6
            DB.modelRepository.AddData(new Model { ModelName = "G55 AMG", BrandId = 3 });       //7
            DB.modelRepository.AddData(new Model { ModelName = "E 250", BrandId = 3 });         //8
            DB.modelRepository.AddData(new Model { ModelName = "S 450 4Matic", BrandId = 3 });  //9
            DB.modelRepository.AddData(new Model { ModelName = "GLE 450", BrandId = 3 });       //10
            DB.modelRepository.AddData(new Model { ModelName = "Optima", BrandId = 4 });        //11
            DB.modelRepository.AddData(new Model { ModelName = "K5", BrandId = 4 });            //12 
            DB.modelRepository.AddData(new Model { ModelName = "Ceed", BrandId = 4 });          //13
            DB.modelRepository.AddData(new Model { ModelName = "Cerato", BrandId = 4 });        //14
            DB.modelRepository.AddData(new Model { ModelName = "Prius", BrandId = 5 });         //15
            DB.modelRepository.AddData(new Model { ModelName = "Camry", BrandId = 5 });         //16
            DB.modelRepository.AddData(new Model { ModelName = "RAV4", BrandId = 5 });          //17

            //BODY
            DB.bodyTypeRepository.AddData(new BodyType { BodyTypeName = "Coupe" }); //1         
            DB.bodyTypeRepository.AddData(new BodyType { BodyTypeName = "Sedan" }); //2         
            DB.bodyTypeRepository.AddData(new BodyType { BodyTypeName = "SUV" });   //3

            //CITY
            DB.cityRepository.AddData(new City { CityName = "Baku" });        //1
            DB.cityRepository.AddData(new City { CityName = "Sumgait" });     //2
            DB.cityRepository.AddData(new City { CityName = "Ganja" });       //3
            DB.cityRepository.AddData(new City { CityName = "Nakhchivan" });  //4

            //COLOR
            DB.colorRepository.AddData(new Color { ColorName = "Red" });  //1
            DB.colorRepository.AddData(new Color { ColorName = "Green" });//2
            DB.colorRepository.AddData(new Color { ColorName = "Blue" }); //3
            DB.colorRepository.AddData(new Color { ColorName = "Gray" }); //4
            DB.colorRepository.AddData(new Color { ColorName = "Gold" }); //5
            DB.colorRepository.AddData(new Color { ColorName = "Black" });//6

            //FUEL
            DB.fuelTypeRepository.AddData(new FuelType { FuelName = "Diesel" });   //1
            DB.fuelTypeRepository.AddData(new FuelType { FuelName = "Gasoline" }); //2
            DB.fuelTypeRepository.AddData(new FuelType { FuelName = "Hybrid" });   //3
            DB.fuelTypeRepository.AddData(new FuelType { FuelName = "Electro" });  //4

            //Niva
            DB.carRepository.AddData(new Car
            {
                ModelId = 1,
                BodyTypeId = 3,
                CityId = 1,
                Engine = "1.7L",
                ImagePath = "https://res.cloudinary.com/dljzepmxr/image/upload/v1687178645/Niva_xly2my.png",
                ColorId = 4,
                IsNew = false,
                Kilometer = 60000,
                Price = 21000,
                ProdYear = new DateTime(2019, 1, 1),
                FuelTypeId = 2,
            });

            //2107
            DB.carRepository.AddData(new Car
            {
                ModelId = 2,
                BodyTypeId = 2,
                CityId = 3,
                Engine = "1.6L",
                ImagePath = "https://res.cloudinary.com/dljzepmxr/image/upload/v1687181182/07_cthi4y.jpg",
                ColorId = 6,
                IsNew = false,
                Kilometer = 110000,
                Price = 9500,
                ProdYear = new DateTime(2010, 1, 1),
                FuelTypeId = 2,
            });

            //Priora
            DB.carRepository.AddData(new Car
            {
                ModelId = 3,
                BodyTypeId = 1,
                CityId = 2,
                Engine = "1.6L",
                ImagePath = "https://res.cloudinary.com/dljzepmxr/image/upload/v1687182176/Priora_jpsqv9.jpg",
                ColorId = 4,
                IsNew = false,
                Kilometer = 50000,
                Price = 20000,
                ProdYear = new DateTime(2018, 1, 1),
                FuelTypeId = 2,
            });

            //M5
            DB.carRepository.AddData(new Car
            {
                ModelId = 4,
                BodyTypeId = 2,
                CityId = 2,
                Engine = "4.4L",
                ImagePath = "https://res.cloudinary.com/dljzepmxr/image/upload/v1687183081/m5_yxlmhx.jpg",
                ColorId = 3,
                IsNew = true,
                Kilometer = 0,
                Price = 200000,
                ProdYear = new DateTime(2023, 1, 1),
                FuelTypeId = 2,
            });

            //X5
            DB.carRepository.AddData(new Car
            {
                ModelId = 5,
                BodyTypeId = 3,
                CityId = 1,
                Engine = "4.4L",
                ImagePath = "https://res.cloudinary.com/dljzepmxr/image/upload/v1687183574/X5M_rycolv.jpg",
                ColorId = 6,
                IsNew = true,
                Kilometer = 0,
                Price = 250000,
                ProdYear = new DateTime(2023, 1, 1),
                FuelTypeId = 2,
            });

            //I8
            DB.carRepository.AddData(new Car
            {
                ModelId = 6,
                BodyTypeId = 2,
                CityId = 1,
                Engine = "0L",
                ImagePath = "https://res.cloudinary.com/dljzepmxr/image/upload/v1687185161/i8_ez117b.jpg",
                ColorId = 3,
                IsNew = false,
                Kilometer = 12544,
                Price = 144500,
                ProdYear = new DateTime(2016, 1, 1),
                FuelTypeId = 4,
            });

            //G55 AMG
            DB.carRepository.AddData(new Car
            {
                ModelId = 7,
                BodyTypeId = 3,
                CityId = 4,
                Engine = "3L",
                ImagePath = "https://res.cloudinary.com/dljzepmxr/image/upload/v1687185697/g55_amg_fec3po.jpg",
                ColorId = 4,
                IsNew = false,
                Kilometer = 80000,
                Price = 88500,
                ProdYear = new DateTime(2011, 1, 1),
                FuelTypeId = 2,
            });

            //E250
            DB.carRepository.AddData(new Car
            {
                ModelId = 8,
                BodyTypeId = 3,
                CityId = 4,
                Engine = "2.2L",
                ImagePath = "https://res.cloudinary.com/dljzepmxr/image/upload/v1687185888/E250_j1fzuo.jpg",
                ColorId = 4,
                IsNew = false,
                Kilometer = 0,
                Price = 76500,
                ProdYear = new DateTime(2016, 1, 1),
                FuelTypeId = 2,
            });

            //S 450 4Matic
            DB.carRepository.AddData(new Car
            {
                ModelId = 9,
                BodyTypeId = 3,
                CityId = 4,
                Engine = "2.2L",
                ImagePath = "https://res.cloudinary.com/dljzepmxr/image/upload/v1687185888/E250_j1fzuo.jpg",
                ColorId = 4,
                IsNew = false,
                Kilometer = 0,
                Price = 76500,
                ProdYear = new DateTime(2016, 1, 1),
                FuelTypeId = 2,
            });

        }
    }
}
