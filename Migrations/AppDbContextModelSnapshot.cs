﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts;

#nullable disable

namespace _420DA3_07451_Projet_Initial.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("_420DA3_07451_Projet_Initial.DataAccess.DTOs.Adresse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CodePostal")
                        .IsRequired()
                        .HasColumnType("nvarchar(6)")
                        .HasColumnName("CodePostal");

                    b.Property<string>("NumeroCivique")
                        .IsRequired()
                        .HasColumnType("nvarchar(8)")
                        .HasColumnName("NumeroCivique");

                    b.Property<string>("Pays")
                        .IsRequired()
                        .HasColumnType("nvarchar(42)")
                        .HasColumnName("Pays");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasColumnType("nvarchar(38)")
                        .HasColumnName("Province");

                    b.Property<byte[]>("Rowversion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion")
                        .HasColumnName("Version");

                    b.Property<string>("Rue")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("Rue");

                    b.Property<string>("Ville")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("Ville");

                    b.HasKey("Id");

                    b.ToTable("Adresse", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CodePostal = "H0H0H0",
                            NumeroCivique = "5A",
                            Pays = "Cehnehdeh",
                            Province = "Quebec",
                            Rue = "rue Saint-Laurent",
                            Ville = "Montréal"
                        },
                        new
                        {
                            Id = 2,
                            CodePostal = "H0H0H0",
                            NumeroCivique = "55A",
                            Pays = "Cehnehdeh",
                            Province = "Quebec",
                            Rue = "rue Saint-Laurent",
                            Ville = "Montréal"
                        },
                        new
                        {
                            Id = 3,
                            CodePostal = "H0H0H0",
                            NumeroCivique = "555A",
                            Pays = "Cehnehdeh",
                            Province = "Quebec",
                            Rue = "rue Saint-Laurent",
                            Ville = "Montréal"
                        },
                        new
                        {
                            Id = 4,
                            CodePostal = "H0H0H0",
                            NumeroCivique = "1A",
                            Pays = "Cehnehdeh",
                            Province = "Quebec",
                            Rue = "rue Saint-Laurent",
                            Ville = "Montréal"
                        },
                        new
                        {
                            Id = 5,
                            CodePostal = "H0H0H0",
                            NumeroCivique = "11A",
                            Pays = "Cehnehdeh",
                            Province = "Quebec",
                            Rue = "rue Saint-Laurent",
                            Ville = "Montréal"
                        },
                        new
                        {
                            Id = 6,
                            CodePostal = "H0H0H0",
                            NumeroCivique = "111A",
                            Pays = "Cehnehdeh",
                            Province = "Quebec",
                            Rue = "rue Saint-Laurent",
                            Ville = "Montréal"
                        });
                });

            modelBuilder.Entity("_420DA3_07451_Projet_Initial.DataAccess.DTOs.ClientsDTO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AsignedWarehouseID")
                        .HasColumnType("int")
                        .HasColumnName("AsignedWarehouseID");

                    b.Property<int>("ClientAdressId")
                        .HasColumnType("int")
                        .HasColumnName("ClientAdressId");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("CompanyName");

                    b.Property<string>("Courriel")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)")
                        .HasColumnName("Courriel");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(24)")
                        .HasColumnName("Nom");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(24)")
                        .HasColumnName("Prenom");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion")
                        .HasColumnName("RowVersion");

                    b.Property<long>("Telephone")
                        .HasColumnType("bigint")
                        .HasColumnName("Telephone");

                    b.HasKey("Id");

                    b.HasIndex("AsignedWarehouseID");

                    b.HasIndex("ClientAdressId")
                        .IsUnique();

                    b.ToTable("Clients", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AsignedWarehouseID = 1,
                            ClientAdressId = 4,
                            CompanyName = "Client Test 1",
                            Courriel = "john.doe@client.net",
                            Nom = "Doe",
                            Prenom = "John",
                            Telephone = 5145555555L
                        },
                        new
                        {
                            Id = 2,
                            AsignedWarehouseID = 1,
                            ClientAdressId = 5,
                            CompanyName = "Normslabs Entertainment Inc.",
                            Courriel = "ze.norm@client.net",
                            Nom = "Norm",
                            Prenom = "Ze",
                            Telephone = 5145551234L
                        });
                });

            modelBuilder.Entity("_420DA3_07451_Projet_Initial.DataAccess.DTOs.Entrepot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AdresseId")
                        .HasColumnType("int")
                        .HasColumnName("AdresseId");

                    b.Property<string>("NomEntrepot")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("NomEntrepot");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion")
                        .HasColumnName("RowVersion");

                    b.HasKey("Id");

                    b.HasIndex("AdresseId")
                        .IsUnique();

                    b.ToTable("Entrepot", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AdresseId = 1,
                            NomEntrepot = "Entrepot Test"
                        });
                });

            modelBuilder.Entity("_420DA3_07451_Projet_Initial.DataAccess.DTOs.Fournisseur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AdresseId")
                        .HasColumnType("int")
                        .HasColumnName("AdresseId");

                    b.Property<string>("EmailContact")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)")
                        .HasColumnName("EmailContact");

                    b.Property<string>("NomContact")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("NomContact");

                    b.Property<string>("PrenomContact")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("PrenomContact");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion")
                        .HasColumnName("RowVersion");

                    b.Property<string>("SupplierName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("NomFournisseur");

                    b.Property<string>("TelephoneContact")
                        .IsRequired()
                        .HasColumnType("nvarchar(24)")
                        .HasColumnName("TelephoneContact");

                    b.HasKey("Id");

                    b.HasIndex("AdresseId")
                        .IsUnique();

                    b.ToTable("Fournisseurs", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AdresseId = 4,
                            EmailContact = "john.doe@fournisseur.net",
                            NomContact = "Doe",
                            PrenomContact = "John",
                            SupplierName = "Fournisseur Test 1",
                            TelephoneContact = "5145555555"
                        });
                });

            modelBuilder.Entity("_420DA3_07451_Projet_Initial.DataAccess.DTOs.Pivots.ShippingOrderProducts", b =>
                {
                    b.Property<int>("ProduitId")
                        .HasColumnType("int")
                        .HasColumnName("ProduitId");

                    b.Property<int>("ShipmentOrderDTOId")
                        .HasColumnType("int")
                        .HasColumnName("ShipmentOrderDTOId");

                    b.Property<int>("Quantite")
                        .HasColumnType("int")
                        .HasColumnName("Quantite");

                    b.HasKey("ProduitId", "ShipmentOrderDTOId");

                    b.HasIndex("ShipmentOrderDTOId");

                    b.ToTable("ShippingOrderProducts", (string)null);
                });

            modelBuilder.Entity("_420DA3_07451_Projet_Initial.DataAccess.DTOs.Pivots.UtilisateursRoles", b =>
                {
                    b.Property<int>("UtilisateurId")
                        .HasColumnType("int")
                        .HasColumnName("UtilisateurId");

                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("RoleId");

                    b.HasKey("UtilisateurId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("RolesUtilisateurs", (string)null);

                    b.HasData(
                        new
                        {
                            UtilisateurId = 1,
                            RoleId = 1
                        },
                        new
                        {
                            UtilisateurId = 1,
                            RoleId = 2
                        },
                        new
                        {
                            UtilisateurId = 1,
                            RoleId = 3
                        });
                });

            modelBuilder.Entity("_420DA3_07451_Projet_Initial.DataAccess.DTOs.Produit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClientsDTOId")
                        .HasColumnType("int")
                        .HasColumnName("ClientsDTOId");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(128)")
                        .HasColumnName("Description");

                    b.Property<bool>("DoAutoRestock")
                        .HasColumnType("bit")
                        .HasColumnName("DoAutoRestock");

                    b.Property<int>("FournisseurId")
                        .HasColumnType("int")
                        .HasColumnName("DournisseurId");

                    b.Property<int>("InstockQuantity")
                        .HasColumnType("int")
                        .HasColumnName("InstockQuantity");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)")
                        .HasColumnName("Name");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion")
                        .HasColumnName("Version");

                    b.Property<string>("SupplierCode")
                        .HasColumnType("nvarchar(4)")
                        .HasColumnName("SupplierCode");

                    b.Property<int>("TargetStockQuantity")
                        .HasColumnType("int")
                        .HasColumnName("TargetStockQuantity");

                    b.Property<long>("UpcCode")
                        .HasColumnType("bigint")
                        .HasColumnName("UpcCode");

                    b.Property<decimal?>("WeightInKg")
                        .HasColumnType("decimal(9,2)")
                        .HasColumnName("WeightInKg");

                    b.HasKey("Id");

                    b.HasIndex("ClientsDTOId");

                    b.HasIndex("FournisseurId");

                    b.ToTable("Produits", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClientsDTOId = 1,
                            Description = "Un produit de test.",
                            DoAutoRestock = true,
                            FournisseurId = 1,
                            InstockQuantity = 50,
                            Name = "TestProduit",
                            SupplierCode = "A535",
                            TargetStockQuantity = 30,
                            UpcCode = 15347634L,
                            WeightInKg = 1.35m
                        },
                        new
                        {
                            Id = 2,
                            ClientsDTOId = 1,
                            Description = "Un produit de test.",
                            DoAutoRestock = true,
                            FournisseurId = 1,
                            InstockQuantity = 50,
                            Name = "TestProduit2",
                            SupplierCode = "A534",
                            TargetStockQuantity = 30,
                            UpcCode = 15347635L,
                            WeightInKg = 1.35m
                        },
                        new
                        {
                            Id = 3,
                            ClientsDTOId = 1,
                            Description = "Un produit de test.",
                            DoAutoRestock = true,
                            FournisseurId = 1,
                            InstockQuantity = 50,
                            Name = "TestProduit3",
                            SupplierCode = "A533",
                            TargetStockQuantity = 30,
                            UpcCode = 15347636L,
                            WeightInKg = 1.35m
                        },
                        new
                        {
                            Id = 4,
                            ClientsDTOId = 1,
                            Description = "Un produit de test.",
                            DoAutoRestock = true,
                            FournisseurId = 1,
                            InstockQuantity = 50,
                            Name = "TestProduit4",
                            SupplierCode = "A532",
                            TargetStockQuantity = 30,
                            UpcCode = 15347637L,
                            WeightInKg = 1.35m
                        });
                });

            modelBuilder.Entity("_420DA3_07451_Projet_Initial.DataAccess.DTOs.PurchaseOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DateCompleted")
                        .HasColumnType("datetime2(7)")
                        .HasColumnName("DateCompleted");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2(7)")
                        .HasColumnName("DateCreated")
                        .HasComputedColumnSql("getdate()");

                    b.Property<int>("DestinationWarehouseID")
                        .HasColumnType("int")
                        .HasColumnName("DestinationWarehouseID");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("ProductId");

                    b.Property<int>("QuantityOrdered")
                        .HasColumnType("int")
                        .HasColumnName("QuantityOrdered");

                    b.Property<byte[]>("RowVersion")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(16)")
                        .HasColumnName("Status");

                    b.HasKey("Id");

                    b.HasIndex("DestinationWarehouseID");

                    b.HasIndex("ProductId");

                    b.ToTable("PurchaseOrders", (string)null);
                });

            modelBuilder.Entity("_420DA3_07451_Projet_Initial.DataAccess.DTOs.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("RoleDescription")
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("Description");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)")
                        .HasColumnName("Name");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion")
                        .HasColumnName("Version");

                    b.HasKey("Id");

                    b.ToTable("Roles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            RoleDescription = "Role Administrateur",
                            RoleName = "Administrator"
                        },
                        new
                        {
                            Id = 2,
                            RoleDescription = "Employés de bureau",
                            RoleName = "OfficeEmployee"
                        },
                        new
                        {
                            Id = 3,
                            RoleDescription = "Employés d'entrepôt",
                            RoleName = "WarehouseEmployee"
                        });
                });

            modelBuilder.Entity("_420DA3_07451_Projet_Initial.DataAccess.DTOs.ShipmentDTO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion")
                        .HasColumnName("Version");

                    b.Property<string>("Service")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("Service");

                    b.Property<int?>("ShippingOrderID")
                        .HasColumnType("int")
                        .HasColumnName("ShippingOrderId");

                    b.Property<string>("TrackingNumber")
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("Tracking number");

                    b.HasKey("Id");

                    b.HasIndex("ShippingOrderID")
                        .IsUnique()
                        .HasFilter("[ShippingOrderId] IS NOT NULL");

                    b.ToTable("Shipments", (string)null);
                });

            modelBuilder.Entity("_420DA3_07451_Projet_Initial.DataAccess.DTOs.ShipmentOrderDTO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClientsId")
                        .HasColumnType("int")
                        .HasColumnName("ClientsId");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2(7)")
                        .HasColumnName("DateCreated")
                        .HasComputedColumnSql("getdate()");

                    b.Property<DateTime?>("DateShipped")
                        .HasColumnType("datetime2(7)")
                        .HasColumnName("DateShipped");

                    b.Property<string>("DestinationCivicAdress")
                        .IsRequired()
                        .HasColumnType("nvarchar(48)")
                        .HasColumnName("DestinationCivicAdress");

                    b.Property<string>("DestinationContact")
                        .IsRequired()
                        .HasColumnType("nvarchar(48)")
                        .HasColumnName("DestinationContact");

                    b.Property<string>("DestinationPostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(7)")
                        .HasColumnName("DestinationPostalCode");

                    b.Property<int?>("EmployeEntrepotId")
                        .HasColumnType("int")
                        .HasColumnName("EmployeEntrepotId");

                    b.Property<int>("EntrepotOriginalId")
                        .HasColumnType("int");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion")
                        .HasColumnName("RowVersion");

                    b.Property<int?>("ShipmentId")
                        .HasColumnType("int")
                        .HasColumnName("ShipmentId");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientsId");

                    b.HasIndex("EmployeEntrepotId");

                    b.HasIndex("EntrepotOriginalId");

                    b.ToTable("ShipmentOrder", (string)null);
                });

            modelBuilder.Entity("_420DA3_07451_Projet_Initial.DataAccess.DTOs.Utilisateur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2(7)")
                        .HasColumnName("DateCreated")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int?>("EntrepotDeTravailId")
                        .HasColumnType("int")
                        .HasColumnName("EntrepotId");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)")
                        .HasColumnName("PasswordHash");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion")
                        .HasColumnName("Version");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(32)")
                        .HasColumnName("Username");

                    b.HasKey("Id");

                    b.HasIndex("EntrepotDeTravailId");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Utilisateurs", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EntrepotDeTravailId = 1,
                            PasswordHash = "659F2E0C66E41C349CC9FF861335D5B0832FAFABB1E5F0D0ADD9B60422BD91EA:C9E12A8B57C22572F0AFA104420B223E:100000:SHA256",
                            Username = "testUser"
                        },
                        new
                        {
                            Id = 2,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EntrepotDeTravailId = 1,
                            PasswordHash = "855300052F84472C14A4AE4EDABACC24C4A07A124557A1A9FD286DFF4673B6C5:61BCD36444EDC7785453AF2E9D5DF877:100000:SHA256",
                            Username = "Max"
                        });
                });

            modelBuilder.Entity("_420DA3_07451_Projet_Initial.DataAccess.DTOs.ClientsDTO", b =>
                {
                    b.HasOne("_420DA3_07451_Projet_Initial.DataAccess.DTOs.Entrepot", "AsignedWarehouse")
                        .WithMany("Clients")
                        .HasForeignKey("AsignedWarehouseID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("_420DA3_07451_Projet_Initial.DataAccess.DTOs.Adresse", "ClientAdress")
                        .WithOne("Client")
                        .HasForeignKey("_420DA3_07451_Projet_Initial.DataAccess.DTOs.ClientsDTO", "ClientAdressId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("AsignedWarehouse");

                    b.Navigation("ClientAdress");
                });

            modelBuilder.Entity("_420DA3_07451_Projet_Initial.DataAccess.DTOs.Entrepot", b =>
                {
                    b.HasOne("_420DA3_07451_Projet_Initial.DataAccess.DTOs.Adresse", "AdresseEntrepot")
                        .WithOne("AdresseEntrepot")
                        .HasForeignKey("_420DA3_07451_Projet_Initial.DataAccess.DTOs.Entrepot", "AdresseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("AdresseEntrepot");
                });

            modelBuilder.Entity("_420DA3_07451_Projet_Initial.DataAccess.DTOs.Fournisseur", b =>
                {
                    b.HasOne("_420DA3_07451_Projet_Initial.DataAccess.DTOs.Adresse", "SupplierAdresse")
                        .WithOne("AdresseFournisseur")
                        .HasForeignKey("_420DA3_07451_Projet_Initial.DataAccess.DTOs.Fournisseur", "AdresseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("SupplierAdresse");
                });

            modelBuilder.Entity("_420DA3_07451_Projet_Initial.DataAccess.DTOs.Pivots.ShippingOrderProducts", b =>
                {
                    b.HasOne("_420DA3_07451_Projet_Initial.DataAccess.DTOs.Produit", "Produit")
                        .WithMany("ShippingOrderProducts")
                        .HasForeignKey("ProduitId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("_420DA3_07451_Projet_Initial.DataAccess.DTOs.ShipmentOrderDTO", "ShipmentOrderDTO")
                        .WithMany("AssociationsProduits")
                        .HasForeignKey("ShipmentOrderDTOId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Produit");

                    b.Navigation("ShipmentOrderDTO");
                });

            modelBuilder.Entity("_420DA3_07451_Projet_Initial.DataAccess.DTOs.Pivots.UtilisateursRoles", b =>
                {
                    b.HasOne("_420DA3_07451_Projet_Initial.DataAccess.DTOs.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_420DA3_07451_Projet_Initial.DataAccess.DTOs.Utilisateur", "Utilisateur")
                        .WithMany()
                        .HasForeignKey("UtilisateurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("Utilisateur");
                });

            modelBuilder.Entity("_420DA3_07451_Projet_Initial.DataAccess.DTOs.Produit", b =>
                {
                    b.HasOne("_420DA3_07451_Projet_Initial.DataAccess.DTOs.ClientsDTO", "ClientsDTO")
                        .WithMany("Produit")
                        .HasForeignKey("ClientsDTOId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("_420DA3_07451_Projet_Initial.DataAccess.DTOs.Fournisseur", "Fournisseur")
                        .WithMany("ProduitsFournis")
                        .HasForeignKey("FournisseurId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ClientsDTO");

                    b.Navigation("Fournisseur");
                });

            modelBuilder.Entity("_420DA3_07451_Projet_Initial.DataAccess.DTOs.PurchaseOrder", b =>
                {
                    b.HasOne("_420DA3_07451_Projet_Initial.DataAccess.DTOs.Entrepot", "DestinationWarehouse")
                        .WithMany("PurchaseOrders")
                        .HasForeignKey("DestinationWarehouseID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("_420DA3_07451_Projet_Initial.DataAccess.DTOs.Produit", "Product")
                        .WithMany("PurchaseOrders")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("DestinationWarehouse");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("_420DA3_07451_Projet_Initial.DataAccess.DTOs.ShipmentDTO", b =>
                {
                    b.HasOne("_420DA3_07451_Projet_Initial.DataAccess.DTOs.ShipmentOrderDTO", "ShippingOrder")
                        .WithOne("Shipment")
                        .HasForeignKey("_420DA3_07451_Projet_Initial.DataAccess.DTOs.ShipmentDTO", "ShippingOrderID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("ShippingOrder");
                });

            modelBuilder.Entity("_420DA3_07451_Projet_Initial.DataAccess.DTOs.ShipmentOrderDTO", b =>
                {
                    b.HasOne("_420DA3_07451_Projet_Initial.DataAccess.DTOs.ClientsDTO", "Clients")
                        .WithMany("ShipmentOrders")
                        .HasForeignKey("ClientsId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("_420DA3_07451_Projet_Initial.DataAccess.DTOs.Utilisateur", "EmployeEntrepot")
                        .WithMany("AssignedShipmentOrders")
                        .HasForeignKey("EmployeEntrepotId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("_420DA3_07451_Projet_Initial.DataAccess.DTOs.Entrepot", "EntrepotOriginal")
                        .WithMany("ShipmentOrder")
                        .HasForeignKey("EntrepotOriginalId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Clients");

                    b.Navigation("EmployeEntrepot");

                    b.Navigation("EntrepotOriginal");
                });

            modelBuilder.Entity("_420DA3_07451_Projet_Initial.DataAccess.DTOs.Utilisateur", b =>
                {
                    b.HasOne("_420DA3_07451_Projet_Initial.DataAccess.DTOs.Entrepot", "EntrepotDeTravail")
                        .WithMany("Utilisateur")
                        .HasForeignKey("EntrepotDeTravailId");

                    b.Navigation("EntrepotDeTravail");
                });

            modelBuilder.Entity("_420DA3_07451_Projet_Initial.DataAccess.DTOs.Adresse", b =>
                {
                    b.Navigation("AdresseEntrepot");

                    b.Navigation("AdresseFournisseur");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("_420DA3_07451_Projet_Initial.DataAccess.DTOs.ClientsDTO", b =>
                {
                    b.Navigation("Produit");

                    b.Navigation("ShipmentOrders");
                });

            modelBuilder.Entity("_420DA3_07451_Projet_Initial.DataAccess.DTOs.Entrepot", b =>
                {
                    b.Navigation("Clients");

                    b.Navigation("PurchaseOrders");

                    b.Navigation("ShipmentOrder");

                    b.Navigation("Utilisateur");
                });

            modelBuilder.Entity("_420DA3_07451_Projet_Initial.DataAccess.DTOs.Fournisseur", b =>
                {
                    b.Navigation("ProduitsFournis");
                });

            modelBuilder.Entity("_420DA3_07451_Projet_Initial.DataAccess.DTOs.Produit", b =>
                {
                    b.Navigation("PurchaseOrders");

                    b.Navigation("ShippingOrderProducts");
                });

            modelBuilder.Entity("_420DA3_07451_Projet_Initial.DataAccess.DTOs.ShipmentOrderDTO", b =>
                {
                    b.Navigation("AssociationsProduits");

                    b.Navigation("Shipment");
                });

            modelBuilder.Entity("_420DA3_07451_Projet_Initial.DataAccess.DTOs.Utilisateur", b =>
                {
                    b.Navigation("AssignedShipmentOrders");
                });
#pragma warning restore 612, 618
        }
    }
}
