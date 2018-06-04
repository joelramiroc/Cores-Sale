[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(CSales.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(CSales.App_Start.NinjectWebCommon), "Stop")]

namespace CSales.App_Start
{
    using System;
    using System.Web;
    using Database.Models;
    using Database.Repositories;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;
    using Ninject;
    using Ninject.Web.Common;
    using Database.Contexts;

    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper Bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application here
        /// </summary>
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            Bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            Bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<MyContext>().ToSelf().InRequestScope();
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
                kernel.Bind<IRepository<Address>>().To<AddressRepository>().InRequestScope();
                kernel.Bind<IRepository<Bank>>().To<BankRepository>().InRequestScope();
                kernel.Bind<IRepository<Bill>>().To<BillRepository>().InRequestScope();
                kernel.Bind<IRepository<BillOfExchange>>().To<BillOfExchangeRepository>().InRequestScope();
                kernel.Bind<IRepository<BusinessName>>().To<BusinessNameRepository>().InRequestScope();
                kernel.Bind<IRepository<Check>>().To<ChekRepository>().InRequestScope();
                kernel.Bind<IRepository<CityDistrict>>().To<CityDistrictRepository>().InRequestScope();
                kernel.Bind<IRepository<Client>>().To<ClientRepository>().InRequestScope();
                kernel.Bind<IRepository<Collection>>().To<CollectionRepository>().InRequestScope();
                kernel.Bind<IRepository<CostCenter>>().To<CostCenterRepository>().InRequestScope();
                kernel.Bind<IRepository<CounterSale>>().To<CounterSaleRepository>().InRequestScope();
                kernel.Bind<IRepository<CreditNote>>().To<CreditNoteRepository>().InRequestScope();
                //kernel.Bind<IRepository<CreditNoteType>>().To<CreditNoteTypeRepository>().InRequestScope();
                kernel.Bind<IRepository<CurrentAccountDocumentType>>().To<CurrentAccountDocumentTypeRepository>().InRequestScope();
                kernel.Bind<IRepository<CurrentAccountProvider>>().To<CurrentAccountProviderRepository>().InRequestScope();
                kernel.Bind<IRepository<CustomerCheckingAccount>>().To<CustomerCheckingAccountRepository>().InRequestScope();
                kernel.Bind<IRepository<DebitNote>>().To<DebitNoteRepository>().InRequestScope();
                kernel.Bind<IRepository<DetailEntryNote>>().To<DetailEntryNoteRepository>().InRequestScope();
                kernel.Bind<IRepository<DetailsProductsToSale>>().To<DetailsProductsToSaleRepository>().InRequestScope();
                kernel.Bind<IRepository<Email>>().To<EmailRepository>().InRequestScope();
                kernel.Bind<IRepository<Employee>>().To<EmployeeRepository>().InRequestScope();
                kernel.Bind<IRepository<EntryNote>>().To<EntryNoteRepository>().InRequestScope();
                kernel.Bind<IRepository<ExternalInventory>>().To<ExternalInventoryRepository>().InRequestScope();
                kernel.Bind<IRepository<Fax>>().To<FaxRepository>().InRequestScope();
                kernel.Bind<IRepository<InternalInventory>>().To<InternalInventoryRepository>().InRequestScope();
                kernel.Bind<IRepository<InternalProduct>>().To<InternalProductRepository>().InRequestScope();
                kernel.Bind<IRepository<Kardex>>().To<KardexRepository>().InRequestScope();
                kernel.Bind<IRepository<MovementsProvider>>().To<MovementsProviderepository>().InRequestScope();
                kernel.Bind<IRepository<MovementType>>().To<MovementsTypeRepository>().InRequestScope();
                kernel.Bind<IRepository<OrderDetail>>().To<OrderDetailRepository>().InRequestScope();
                kernel.Bind<IRepository<OutputNote>>().To<OutputNoteRepository>().InRequestScope();
                kernel.Bind<IRepository<PaymentCondition>>().To<PaymentConditionRepository>().InRequestScope();
                kernel.Bind<IRepository<PaymentMethod>>().To<PaymentMethodRepository>().InRequestScope();
                kernel.Bind<IRepository<Product>>().To<ProductRepository>().InRequestScope();
                kernel.Bind<IRepository<ProductLine>>().To<ProductLineRepository>().InRequestScope();
                kernel.Bind<IRepository<ProductType>>().To<ProductTypeRepository>().InRequestScope();
                kernel.Bind<IRepository<Provider>>().To<ProviderRepository>().InRequestScope();
                kernel.Bind<IRepository<PurchaseDocument>>().To<PurchaseDocumentRepository>().InRequestScope();
                kernel.Bind<IRepository<PurchaseOrder>>().To<PurchaseOrderRepository>().InRequestScope();
                kernel.Bind<IRepository<ReasonNote>>().To<ReasonNoteRepository>().InRequestScope();
                kernel.Bind<IRepository<RUC>>().To<RUCRepository>().InRequestScope();
                kernel.Bind<IRepository<Sale>>().To<SaleRepository>().InRequestScope();
                kernel.Bind<IRepository<SaleOrder>>().To<SaleOrderRepository>().InRequestScope();
                kernel.Bind<IRepository<SalesByDispatch>>().To<SalesByDispatchRepository>().InRequestScope();
                kernel.Bind<IRepository<StatusNote>>().To<StatusNoteRepository>().InRequestScope();
                kernel.Bind<IRepository<Storage>>().To<StorageRepository>().InRequestScope();
                kernel.Bind<IRepository<Telephone>>().To<TelephoneRepository>().InRequestScope();
                kernel.Bind<IRepository<TypeOfPurchaseDocument>>().To<TypeOfPuchaseDocumentRepository>().InRequestScope();
                kernel.Bind<IRepository<TypeOfSaleDocument>>().To<TypeOfSaleDocumentRepository>().InRequestScope();
                kernel.Bind<IRepository<UnitOfMeasurement>>().To<UnitOfMeasurementRepository>().InRequestScope();
                kernel.Bind<IRepository<Voucher>>().To<VoucherRepository>().InRequestScope();

                // kernel.Bind<IRepository<>>().To<>();
                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
        }
    }
}
