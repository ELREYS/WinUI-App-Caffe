

using System.ComponentModel;
using WiredBrainCoffee.Model;

namespace WiredBrainCoffee.ViewModel
{
    public  class CustomerItemViewModel:ViewModelBase
    {
        private readonly Customer _model;

        public CustomerItemViewModel(Customer model) 
        {
            _model = model;
        }
        public int Id => _model.Id;

     
        public string? FirstName
        {
            get => _model.FirstName;
            set { if (_model.FirstName != value) 
                {
                    _model.FirstName = value;
                    RaisePropertyChnaged();

                } 
            }
        }

        public string? LastName
        {
            get => _model.LastName;
            set
            {
                if (_model.LastName != value)
                {
                    _model.LastName = value;
                    RaisePropertyChnaged();

                }
            }
        }

        public bool IsDeveloper
        {
            get => _model.IsDeveloper;
            set
            {
                if (_model.IsDeveloper != value)
                {
                    _model.IsDeveloper = value;
                    RaisePropertyChnaged();

                }
            }
        }

    }
}
