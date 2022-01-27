using HotelLandon.Models;
using HotelLandon.Repository;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using Xunit;

namespace HotelLandon.Tests
{
    public class CutomersTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange : initialiser vos variables
            Customer customer = new()
            {
                FirstName = "Andres"
            };

            // Act : Exécuter les opérations nécessaires


            // Assert : Vérifiez que le résultat attendu est égale à celui produit
            Assert.True(customer.FirstName.Length > 3);
        }

        [Fact]
        public void FirstNameDoitAvoir3Caracteres_AvecUneLettre()
        {
            // Arrange
            Customer customer = new()
            {
                FirstName = "A"
            };

            // Act

            // Assert
            Assert.False(customer.FirstName.Length > 3);
        }

        [Fact]
        public void Test3()
        {
            // Arrange
            Customer customer = new()
            {
                BirthDate = DateTime.Today.AddYears(-120)
            };

            // Act

            // Assert
            Assert.Throws<TropVieuxException>(() =>
            {
                // Ajouter une vérification au niveau du Customer
            });
        }

        [Fact]
        public void VerifDate()
        {
            var rand = new Random();
            int jours = rand.Next(1, 31);
            Customer customer = new()
            {

                BirthDate = new DateTime(jours, 02, 2000)
            };

            string rslt = customer.BirthDate.ToString("dd/MM/yyyy");


        }



        [Fact]
        public void FirstName_Only_Alphabet()
        {

            // Arrange
            Customer customer = new()
            {
                FirstName = "Lassina"
            };

            // Act
            
           
            // Assert
            Assert.False(!Regex.IsMatch(customer.FirstName, @"^[a-zA-Z]+$"));
        }









    }
}
