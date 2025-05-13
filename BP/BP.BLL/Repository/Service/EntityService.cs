using BP.BLL.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP.BLL.Repository.Service
{
    public class EntityService
    {
        public EntityService()
        {
            _cargoService = new CargoRepository();
            _cityService = new CityRepository();
            _companyCargoService = new CompanyCargoRepository();
            _companyService = new CompanyRepository();
            _companyUserService = new CompanyUserRepository();
            _distictService = new DistictRepository();
            _quarterService = new QuarterRepository();
            _receiverAdressService = new ReceiverAdressRepository();
            _receiverService = new ReceiverRepository();
            _shippingService = new ShippingRepository();
            _taxAdministraitionService = new TaxAdministraitionRepository();
            _userService = new UserRepository();
            _shippingLogService = new ShippingLogRepository();
        }

        private CargoRepository _cargoService;

        public CargoRepository CargoService
        {
            get { return _cargoService; }
            set { _cargoService = value; }
        }

        private CityRepository _cityService;

        public CityRepository CityService
        {
            get { return _cityService; }
            set { _cityService = value; }
        }

        private CompanyCargoRepository _companyCargoService;

        public CompanyCargoRepository CompanyCargoService
        {
            get { return _companyCargoService; }
            set { _companyCargoService = value; }
        }
        private CompanyRepository _companyService;

        public CompanyRepository CompanyService
        {
            get { return _companyService; }
            set { _companyService = value; }
        }

        private CompanyUserRepository _companyUserService;

        public CompanyUserRepository CompanyUserService
        {
            get { return _companyUserService; }
            set { _companyUserService = value; }
        }

        private DistictRepository _distictService;

        public DistictRepository DistictService
        {
            get { return _distictService; }
            set { _distictService = value; }
        }

        private QuarterRepository _quarterService;

        public QuarterRepository QuarterService
        {
            get { return _quarterService; }
            set { _quarterService = value; }
        }

        private ReceiverAdressRepository _receiverAdressService;

        public ReceiverAdressRepository ReceiverAdressService
        {
            get { return _receiverAdressService; }
            set { _receiverAdressService = value; }
        }

        private ReceiverRepository _receiverService;

        public ReceiverRepository ReceiverService
        {
            get { return _receiverService; }
            set { _receiverService = value; }
        }

        private ShippingRepository _shippingService;

        public ShippingRepository ShippingService
        {
            get { return _shippingService; }
            set { _shippingService = value; }
        }

        private TaxAdministraitionRepository _taxAdministraitionService;

        public TaxAdministraitionRepository TaxAdministraitionService
        {
            get { return _taxAdministraitionService; }
            set { _taxAdministraitionService = value; }
        }

        private UserRepository _userService;

        public UserRepository UserService
        {
            get { return _userService; }
            set { _userService = value; }
        }

        private ShippingLogRepository _shippingLogService;

        public ShippingLogRepository ShippingLogService
        {
            get { return _shippingLogService; }
            set { _shippingLogService = value; }
        }







    }
}
