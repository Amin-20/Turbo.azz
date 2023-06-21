using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.az_app.Commands;
using Turbo.az_app.Domain.Views.UserControls;
using Turbo.az_app.Entities.Mapping;

namespace Turbo.az_app.Domain.ViewModel.UserControlViewModels
{
    public class CarUCViewModel : BaseViewModel
    {
        public RelayCommand SelectedCarCommand { get; set; }

        private Car selectedCar;

        public Car SelectedCar
        {
            get { return selectedCar; }
            set { selectedCar = value; OnPropertyChanged(); }
        }


        private string carImagePath;

        public string CarImagePath
        {
            get { return carImagePath; }
            set { carImagePath = value; OnPropertyChanged(); }
        }

        private string carPrice;

        public string CarPrice
        {
            get { return carPrice; }
            set { carPrice = value; OnPropertyChanged(); }
        }

        private string carModelBrandInfo;

        public string CarModelBrandInfo
        {
            get { return carModelBrandInfo; }
            set { carModelBrandInfo = value; OnPropertyChanged(); }
        }

        private string carKmYearInfo;

        public string CarKmYearInfo
        {
            get { return carKmYearInfo; }
            set { carKmYearInfo = value; OnPropertyChanged(); }
        }

        public CarUCViewModel()
        {
            SelectedCarCommand = new RelayCommand((obj) =>
            {
                App.CarWrapPanel.Children.Clear();
                CarInfoUC carInfoUC = new CarInfoUC();
                CarInfoUcViewModel carInfoUCViewModel = new CarInfoUcViewModel();
                carInfoUCViewModel.CarImage = SelectedCar.ImagePath;
                carInfoUCViewModel.CarPrice = $"{SelectedCar.Price} ₼";
                carInfoUCViewModel.CarBrand = SelectedCar.Model.Brand.BrandName;
                carInfoUCViewModel.CarYear = SelectedCar.ProdYear.Year.ToString();
                carInfoUCViewModel.CarModel = SelectedCar.Model.ModelName;
                carInfoUCViewModel.CarCity = SelectedCar.City.CityName;
                carInfoUCViewModel.CarColor = SelectedCar.Color.ColorName;
                carInfoUC.DataContext = carInfoUCViewModel;
                App.CarWrapPanel.Children.Add(carInfoUC);
            });
        }

    }
}
