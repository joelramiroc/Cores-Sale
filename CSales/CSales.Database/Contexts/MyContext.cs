// <copyright file="MyContext.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CSales.Database.Contexts
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;
    using System.Web;
    using CSales.Database.Models;
    using FirebirdSql.Data.FirebirdClient;

    public class MyContext : DbContext
    {
        public MyContext()
            : base(new FbConnection(@"database=localhost:C:\BASE\TEST.FDB;user=SYSDBA;password=masterkey"), true)
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Provider> Provider { get; set; }

        public DbSet<Address> Address { get; set; }

        public DbSet<Bank> Bank { get; set; }

        public DbSet<DetailsProductsToSale> DetailsProductsToSale { get; set; }

        public DbSet<Bill> Bill { get; set; }

        public DbSet<BillOfExchange> BillOfExchange { get; set; }

        public DbSet<Check> Chek { get; set; }

        public DbSet<BusinessName> BusinessName { get; set; }

        public DbSet<DetailEntryNote> DetailEntryNote { get; set; }

        public DbSet<CityDistrict> CityDistrict { get; set; }

        public DbSet<Client> Client { get; set; }

        public DbSet<Collection> Collection { get; set; }

        public DbSet<CostCenter> CostCenter { get; set; }

        public DbSet<CounterSale> CounterSale { get; set; }

        public DbSet<CreditNote> CreditNote { get; set; }

        public DbSet<CurrentAccountDocumentType> CurrentAccountDocumentType { get; set; }

        public DbSet<CurrentAccountProvider> CurrentAcountProvider { get; set; }

        public DbSet<CustomerCheckingAccount> CustomerCheckingAccount { get; set; }

        public DbSet<DebitNote> DebitNote { get; set; }
        
        public DbSet<Email> Email { get; set; }

        public DbSet<Employee> Employee { get; set; }

        public DbSet<EntryNote> EntryNote { get; set; }

        public DbSet<ExternalInventory> ExternalInventory { get; set; }

        public DbSet<ExternalProduct> ExternalProduct { get; set; }

        public DbSet<Fax> Fax { get; set; }

        public DbSet<InternalInventory> InternalInventory { get; set; }

        public DbSet<InternalProduct> InternalProduct { get; set; }

        public DbSet<Kardex> Kardex { get; set; }

        public DbSet<MovementType> MovementType { get; set; }

        public DbSet<MovementsProvider> MovementsProvider { get; set; }

        public DbSet<OutputNote> OuputNote { get; set; }

        public DbSet<OrderDetail> OrderDetail { get; set; }

        public DbSet<PaymentCondition> PaymentCondition { get; set; }

        public DbSet<PaymentMethod> PaymentMethod { get; set; }

        public DbSet<Product> Product { get; set; }

        public DbSet<ProductLine> ProductLine { get; set; }

        public DbSet<ProductType> ProductType { get; set; }

        public DbSet<PurchaseDocument> PurchaseDocument { get; set; }

        public DbSet<PurchaseOrder> PurchaseOrder { get; set; }

        public DbSet<ReasonNote> ReasonNote { get; set; }

        public DbSet<RUC> RUC { get; set; }

        public DbSet<Sale> Sale { get; set; }

        public DbSet<SaleOrder> SaleOrder { get; set; }

        public DbSet<SalesByDispatch> SalesByDispatch { get; set; }

        public DbSet<StatusNote> StatusNote { get; set; }

        public DbSet<Storage> Storage { get; set; }

        public DbSet<Telephone> Telephone { get; set; }

        public DbSet<TypeOfPurchaseDocument> TypeOfPurchaseDocument { get; set; }

        public DbSet<TypeOfSaleDocument> TypeOfSaleDocument { get; set; }

        public DbSet<UnitOfMeasurement> UnitOfMeasurement { get; set; }

        public DbSet<Voucher> Voucher { get; set; }

    // public DbSet<>  { get; set; }
    }
}