using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.az_app.Commands;

namespace Turbo.az_app.Domain.ViewModel.UserControlViewModels
{
    public class CarInfoUcViewModel:BaseViewModel
    {
        public RelayCommand BackCommand { get; set; }

        private string carImage;

		public string CarImage
		{
			get { return carImage; }
			set { carImage = value; OnPropertyChanged(); }
		}

        private string carBrand;

        public string CarBrand
        {
            get { return carBrand; }
            set { carBrand = value; OnPropertyChanged(); }
        }

        private string carModel;

        public string CarModel
        {
            get { return carModel; }
            set { carModel = value; OnPropertyChanged(); }
        }

        private string carCity;

        public string CarCity
        {
            get { return carCity; }
            set { carCity = value; OnPropertyChanged(); }
        }

        private string carColor;

        public string CarColor
        {
            get { return carColor; }
            set { carColor = value; OnPropertyChanged(); }
        }

        private string carYear;

        public string CarYear
        {
            get { return carYear; }
            set { carYear = value; OnPropertyChanged(); }
        }
        private string carPrice;

        public string CarPrice
        {
            get { return carPrice; }
            set { carPrice = value; OnPropertyChanged(); }
        }

        public CarInfoUcViewModel()
        {
            BackCommand = new RelayCommand((obj) =>
            {
                var vm=new MainWindowViewModel();
            });
        }
    }

}
