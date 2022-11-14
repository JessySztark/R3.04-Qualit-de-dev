using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculatrice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice.Tests
{
    [TestClass()]
    public class CalculTests
    {

        // Addition 

        [TestMethod()]
        public void AdditionTest_AvecValeur_1_2_Retourne3()
        {
            //Arrange
            Double a = 1.0;
            Double b = 2.0;
            //Act
            Double resultat = Calcul.Addition(a, b);
            //Assert
            Assert.AreEqual(3.0, resultat, "Test non OK. La valeur doit être égale à 3");
        }

        [TestMethod()]
        public void AdditionTest_AvecValeur_moins1_moins2_RetourneMoins3()
        {
            //Arrange
            Double a = -1.0;
            Double b = -2.0;
            //Act
            Double resultat = Calcul.Addition(a, b);
            //Assert
            Assert.AreEqual(-3.0, resultat, "Test non OK. La valeur doit être égale à 3");
        }

        [TestMethod()]
        public void AdditionTest_AvecValeur_1_moins2_RetourneMoins1()
        {
            //Arrange
            Double a = 1.0;
            Double b = -2.0;
            //Act
            Double resultat = Calcul.Addition(a, b);
            //Assert
            Assert.AreEqual(-1.0, resultat, "Test non OK. La valeur doit être égale à 3");
        }

        [TestMethod()]
        public void AdditionTest_AvecValeur_0_0_Retourne0()
        {
            //Arrange
            Double a = 0.0;
            Double b = 0.0;
            //Act
            Double resultat = Calcul.Addition(a, b);
            //Assert
            Assert.AreEqual(0.0, resultat, "Test non OK. La valeur doit être égale à 3");
        }

        // Soustraction

        [TestMethod()]
        public void SoustractionTest_AvecValeur_1_2_RetourneMoins1()
        {
            //Arrange
            Double a = 1.0;
            Double b = 2.0;
            //Act
            Double resultat = Calcul.Soustraction(a, b);
            //Assert
            Assert.AreEqual(-1.0, resultat, "Test non OK. La valeur doit être égale à 3");
        }

        [TestMethod()]
        public void SoustractionTest_AvecValeur_moins1_moins2_Retourne1()
        {
            //Arrange
            Double a = -1.0;
            Double b = -2.0;
            //Act
            Double resultat = Calcul.Soustraction(a, b);
            //Assert
            Assert.AreEqual(1.0, resultat, "Test non OK. La valeur doit être égale à 3");
        }

        [TestMethod()]
        public void SoustractionTest_AvecValeur_1_moins2_Retourne3()
        {
            //Arrange
            Double a = 1.0;
            Double b = -2.0;
            //Act
            Double resultat = Calcul.Soustraction(a, b);
            //Assert
            Assert.AreEqual(3.0, resultat, "Test non OK. La valeur doit être égale à 3");
        }

        [TestMethod()]
        public void SoustractionTest_AvecValeur_0_0_Retourne0()
        {
            //Arrange
            Double a = 0.0;
            Double b = 0.0;
            //Act
            Double resultat = Calcul.Soustraction(a, b);
            //Assert
            Assert.AreEqual(0.0, resultat, "Test non OK. La valeur doit être égale à 3");
        }

        // Multiplication

        [TestMethod()]
        public void MultiplicationTest_AvecValeur_1_2_Retourne2()
        {
            //Arrange
            Double a = 1.0;
            Double b = 2.0;
            //Act
            Double resultat = Calcul.Multiplication(a, b);
            //Assert
            Assert.AreEqual(2.0, resultat, "Test non OK. La valeur doit être égale à 3");
        }

        [TestMethod()]
        public void MultiplicationTest_AvecValeur_moins1_moins2_Retourne2()
        {
            //Arrange
            Double a = -1.0;
            Double b = -2.0;
            //Act
            Double resultat = Calcul.Multiplication(a, b);
            //Assert
            Assert.AreEqual(2.0, resultat, "Test non OK. La valeur doit être égale à 3");
        }

        [TestMethod()]
        public void MultiplicationTest_AvecValeur_1_moins2_RetourneMoins2()
        {
            //Arrange
            Double a = 1.0;
            Double b = -2.0;
            //Act
            Double resultat = Calcul.Multiplication(a, b);
            //Assert
            Assert.AreEqual(-2.0, resultat, "Test non OK. La valeur doit être égale à 3");
        }

        [TestMethod()]
        public void MultiplicationTest_AvecValeur_0_0_Retourne0()
        {
            //Arrange
            Double a = 0.0;
            Double b = 0.0;
            //Act
            Double resultat = Calcul.Multiplication(a, b);
            //Assert
            Assert.AreEqual(0.0, resultat, "Test non OK. La valeur doit être égale à 3");
        }

        [TestMethod()]
        public void MultiplicationTest_AvecValeur_1_0_Retourne0()
        {
            //Arrange
            Double a = 1.0;
            Double b = 0.0;
            //Act
            Double resultat = Calcul.Multiplication(a, b);
            //Assert
            Assert.AreEqual(0.0, resultat, "Test non OK. La valeur doit être égale à 3");
        }

        // Division

        [TestMethod()]
        public void DivisionTest_AvecValeur_1_2_Retourne0virgule5()
        {
            //Arrange
            Double a = 1.0;
            Double b = 2.0;
            //Act
            Double resultat = Calcul.Division(a, b);
            //Assert
            Assert.AreEqual(0.5, resultat, "Test non OK. La valeur doit être égale à 3");
        }

        [TestMethod()]
        public void DivisionTest_AvecValeur_1_moins2_Retourne0virgule5()
        {
            //Arrange
            Double a = 1.0;
            Double b = -2.0;
            //Act
            Double resultat = Calcul.Division(a, b);
            //Assert
            Assert.AreEqual(-0.5, resultat, "Test non OK. La valeur doit être égale à 3");
        }

        [TestMethod()]
        public void DivisionTest_AvecValeur_0_1_Retourne0()
        {
            //Arrange
            Double a = 0.0;
            Double b = 1.0;
            //Act
            Double resultat = Calcul.Division(a, b);
            //Assert
            Assert.AreEqual(0.0, resultat, "Test non OK. La valeur doit être égale à 3");
        }

        [TestMethod()]
        public void DivisionTest_AvecValeur_1_0_RetourneException()
        {
            DivideByZeroException expectedException = null;
            try
            {
                //Arrange
                Double a = 1.0;
                Double b = 0.0;
                //Act
                Double resultat = Calcul.Division(a, b);
            }
            catch(DivideByZeroException ex)
            {
                expectedException = ex;
            }
            //Assert
            Assert.IsNotNull(expectedException, "Text non ok. Erreur exception");
        }

        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivisionTest_AvecValeur_1_0_RetourneDividedByZeroException()
        {
            try
            {
                //Arrange
                Double a = 1.0;
                Double b = 0.0;
                //Act
                Double resultat = Calcul.Division(a, b);
            }
            catch (DivideByZeroException ex)
            {
                throw ex;
            }
        }

        // Factorielle

        [TestMethod()]
        public void FactorielleTest_AvecValeur_0_Retourne1()
        {
            //Arrange
            Double a = 0;
            //Act
            Double resultat = Calcul.Factorielle(a);
            //Assert
            Assert.AreEqual(1, resultat, "Test non OK. La valeur doit être égale à 3");
        }

        [TestMethod()]
        public void FactorielleTest_AvecValeur_1_Retourne1()
        {
            //Arrange
            Double a = 1;
            //Act
            Double resultat = Calcul.Factorielle(a);
            //Assert
            Assert.AreEqual(1, resultat, "Test non OK. La valeur doit être égale à 3");
        }

        [TestMethod()]
        public void FactorielleTest_AvecValeur_10_Retourne3628800()
        {
            //Arrange
            Double a = 10;
            //Act
            Double resultat = Calcul.Factorielle(a);
            //Assert
            Assert.AreEqual(3628800, resultat, "Test non OK. La valeur doit être égale à 3");
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void FactorielleTest_AvecValeur_inf0_RetourneArgumentException()
        {
            try
            {
                //Arrange
                Double a = -5.99;
                //Act
                Double resultat = Calcul.Factorielle(a);
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void FactorielleTest_AvecValeur_pas_entier_RetourneArgumentException()
        {
            try
            {
                //Arrange
                Double a = 5.99;
                //Act
                Double resultat = Calcul.Factorielle(a);
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
        }
    }
}