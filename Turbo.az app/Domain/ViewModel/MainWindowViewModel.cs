using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.az_app.Commands;
using Turbo.az_app.Domain.ViewModel.UserControlViewModels;
using Turbo.az_app.Domain.Views.UserControls;
using Turbo.az_app.Entities;
using Turbo.az_app.Entities.Mapping;

namespace Turbo.az_app.Domain.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        public RelayCommand ShowCommand { get; set; }
        public RelayCommand SelectionBrandCommand { get; set; }
        public RelayCommand SelectionModelCommand { get; set; }
        public RelayCommand AllCommand { get; set; }
        public RelayCommand NewCommand { get; set; }
        public RelayCommand OldCommand { get; set; }


        public Brand SelectionBrand { get; set; }
        public Model SelectionModel { get; set; }

        public bool isAll { get; set; } = true;
        public bool isNew { get; set; } = false;



        private ObservableCollection<Brand> brands;


        private bool isBrandSelected = false;

        public bool IsBrandSelected
        {
            get { return isBrandSelected; }
            set { isBrandSelected = value; OnPropertyChanged(); }
        }


        public ObservableCollection<Brand> Brands
        {
            get { return brands; }
            set { brands = value; OnPropertyChanged(); }
        }

        private ObservableCollection<Model> models;

        public ObservableCollection<Model> Models
        {
            get { return models; }
            set { models = value; OnPropertyChanged(); }
        }

        private ObservableCollection<BodyType> bodyType;

        public ObservableCollection<BodyType> BodyTypes
        {
            get { return bodyType; }
            set { bodyType = value; OnPropertyChanged(); }
        }

        private ObservableCollection<Color> colors;

        public ObservableCollection<Color> Colors
        {
            get { return colors; }
            set { colors = value; OnPropertyChanged(); }
        }

        private ObservableCollection<FuelType> fuelTypes;

        public ObservableCollection<FuelType> FuelTypes
        {
            get { return fuelTypes; }
            set { fuelTypes = value; OnPropertyChanged(); }
        }

        private ObservableCollection<Car> cars;

        public ObservableCollection<Car> Cars
        {
            get { return cars; }
            set { cars = value; }
        }

        public bool IsModelSelected { get; set; } = false;

        public void CallCarUc(List<Car> cars)
        {
            App.CarWrapPanel.Children.Clear();
            CarUC carUC;
            CarUCViewModel carUCViewModel;
            for (int i = 0; i < cars.Count; i++)
            {
                carUC = new CarUC();
                carUCViewModel = new CarUCViewModel();
                carUCViewModel.SelectedCar= cars[i];
                carUCViewModel.CarImagePath = cars[i].ImagePath;
                carUCViewModel.CarPrice = $"{cars[i].Price} ₼";
                carUCViewModel.CarModelBrandInfo = $"{cars[i].Model.Brand.BrandName} {cars[i].Model.ModelName}";
                carUCViewModel.CarKmYearInfo = $"{cars[i].ProdYear.Year}, {cars[i].Engine}, {cars[i].Kilometer} km";
                carUC.DataContext = carUCViewModel;
                App.CarWrapPanel.Children.Add(carUC);
            }
        }

        public MainWindowViewModel()
        {
            Brands = new ObservableCollection<Brand>(App.DB.brandRepository.GetAll());
            BodyTypes = new ObservableCollection<BodyType>(App.DB.bodyTypeRepository.GetAll());
            Colors = new ObservableCollection<Color>(App.DB.colorRepository.GetAll());
            FuelTypes = new ObservableCollection<FuelType>(App.DB.fuelTypeRepository.GetAll());
            Cars = new ObservableCollection<Car>(App.DB.carRepository.GetAll());
            CallCarUc(cars.ToList());

            SelectionBrandCommand = new RelayCommand((obj) =>
            {
                var id = SelectionBrand.Id;
                Models = new ObservableCollection<Model>(App.DB.modelRepository.GetAllId(id));
                IsBrandSelected = true;
                IsModelSelected = false;
            });

            SelectionModelCommand = new RelayCommand((obj) =>
            {
                IsModelSelected = true;
            });

            ShowCommand = new RelayCommand((obj) =>
            {
                if (!IsModelSelected || isAll)
                {

                    var allCars = Cars.Where(c => c.Model.BrandId == SelectionBrand.Id).ToList();
                    CallCarUc(allCars);
                }
                if (isNew)
                {
                    var allCars = Cars.Where(c => c.Model.BrandId == SelectionBrand.Id && c.IsNew == true).ToList();
                    CallCarUc(allCars);
                }
                else if (!isNew && !isAll)
                {
                    var allCars = Cars.Where(c => c.Model.BrandId == SelectionBrand.Id && c.IsNew == false).ToList();
                    CallCarUc(allCars);
                }
                if (IsModelSelected)
                {
                    var allCars = Cars.Where(c => c.ModelId == SelectionModel.Id).ToList();
                    CallCarUc(allCars);

                }
            });

            AllCommand = new RelayCommand((obj) =>
            {
                isAll = true;
            });

            NewCommand = new RelayCommand((obj) =>
            {
                isNew = true;
                isAll = false;
            });

            OldCommand = new RelayCommand((obj) =>
            {
                isNew = false;
                isAll = false;
            });

        }
    }
}
