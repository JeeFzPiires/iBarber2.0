using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using iBarber.Modelos;

namespace iBarber.Dados.EntityFramework
{
    public class Contexto : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var conn = @"Data source = 201.62.57.93;
                                    Database = BD040690;
                                    User ID = RA040690; 
                                    Password = 040690";
            optionsBuilder.UseSqlServer(conn);
        }

        //Nome das Classes que representarão o Banco de Dados
        public DbSet<Barbearia> Barbearia { get; set; }

        public DbSet<Barbeiro> Barbeiro { get; set; }

        public DbSet<Agendamento> Agendamento { get; set; }

        //Definição das características das classes com as tabelas
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Barbearia>()
                .ToTable("Barbearias")
                .HasKey("BarbeariaID");

            modelBuilder.Entity<Barbearia>()
                .Property("CNPJ")
                .HasColumnName("CNPJ")
                .HasColumnType("char(14)")
                .IsRequired();

            modelBuilder.Entity<Barbearia>()
                .Property("Nome")
                .HasColumnName("Nome")
                .HasColumnType("varchar(100)")
                .IsRequired();

            modelBuilder.Entity<Barbearia>()
                .Property("Local")
                .HasColumnName("Local")
                .HasColumnType("varchar(100)")
                .IsRequired();

            //-------------Model Barbeiro----------------------

            modelBuilder.Entity<Barbeiro>()
               .ToTable("Barbeiro")
               .HasKey("BarbeiroID");

            modelBuilder.Entity<Barbeiro>()
                .Property("Nome")
                .HasColumnName("Nome")
                .HasColumnType("varchar(200)")
                .IsRequired();

            modelBuilder.Entity<Barbeiro>()
                .Property("CPF")
                .HasColumnName("CPF")
                .HasColumnType("char(11)")
                .IsRequired();

            modelBuilder.Entity<Barbeiro>()
                .Property("Telefone")
                .HasColumnName("Telefone")
                .HasColumnType("char(10)")
                .IsRequired();

            //---------------------- Agendamento ---------------------------

            modelBuilder.Entity<Agendamento>()
               .ToTable("Agendamento")
               .HasKey("AgendamentoID");

            modelBuilder.Entity<Agendamento>()
                .Property("DataHoraInicio")
                .HasColumnName("DataHoraInicio")
                .HasColumnType("date")
                .IsRequired();

            modelBuilder.Entity<Agendamento>()
                .Property("DataHoraFinal")
                .HasColumnName("DataHoraFinal")
                .HasColumnType("date")
                .IsRequired();

            modelBuilder.Entity<Agendamento>()
                .Property("ComentarioAvaliacao")
                .HasColumnName("ComentarioAvaliacao")
                .HasColumnType("varchar(200)")
                .IsRequired();

            modelBuilder.Entity<Agendamento>()
                .Property("EstrelaAvaliacao")
                .HasColumnName("EstrelaAvaliacao")
                .HasColumnType("char(5)")
                .IsRequired();

            modelBuilder.Entity<Agendamento>()
                .Property("BarbeariaID")
                .HasColumnName("BarbeariaID")
                .HasColumnType("int")
                .IsRequired();

            modelBuilder.Entity<Agendamento>()
                .Property("BarbeiroID")
                .HasColumnName("BarbeiroID")
                .HasColumnType("int")
                .IsRequired();


            base.OnModelCreating(modelBuilder);
        }

       





    }
}
