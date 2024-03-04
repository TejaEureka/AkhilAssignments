﻿// <auto-generated />
using EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EntityFramework.Migrations
{
    [DbContext(typeof(ProfileContext))]
    partial class ProfileContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EntityFramework.ProfileModels.FavoriteStocksModel", b =>
                {
                    b.Property<int>("FavoriteStockId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("favorite_stock_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("FavoriteStockId"));
                    NpgsqlPropertyBuilderExtensions.HasIdentityOptions(b.Property<int>("FavoriteStockId"), 1L, null, 1L, null, null, null);

                    b.Property<string>("TickerSymbol")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("character varying(25)")
                        .HasColumnName("ticket_symbol");

                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("user_id");

                    b.HasKey("FavoriteStockId")
                        .HasName("FavoriteStocks_pkey_akhil");

                    b.ToTable("favorite_stocks_akhil", "endeavour_test_area", t =>
                        {
                            t.HasComment("Table that contains the data for a user favorite stocks, i.e. UserId and ticker symbol");
                        });
                });

            modelBuilder.Entity("EntityFramework.ProfileModels.UserModel", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("user_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("UserId"));
                    NpgsqlPropertyBuilderExtensions.HasIdentityOptions(b.Property<int>("UserId"), 1L, null, 1L, 500L, null, null);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("city");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("email");

                    b.Property<string>("FistName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("last_name");

                    b.HasKey("UserId")
                        .HasName("Users_pkey_akhil");

                    b.ToTable("users_akhil", "endeavour_test_area", t =>
                        {
                            t.HasComment("Table that contains the data for a user profiles, i.e. UserId and FistName, LastName");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}