using Bibo.Models;
using Bibo.Services;

namespace Bibo.Specs
{
    [TestClass]
    public sealed class LoginTests
    {
        //Personal-Login geht
        [TestMethod]
        public void Admin_Login_Sollte_Personal_Zurueckgeben()
        {
            // Arrange
            var service = new LoginService();

            // Act
            var result = service.CheckLogin("Admin", "NaSon");

            // Assert
            Assert.AreEqual(LoginResult.Personal, result.Result);
        }


        //Kunden-Login geht und gibt Kunde zurück
        [TestMethod]
        public void Kunde_Login_Sollte_Kunde_Zurueckgeben()
        {
            // Arrange
            var service = new LoginService();

            // Act
            var result = service.CheckLogin("n.nadine", "nadine");

            // Assert
            Assert.AreEqual(LoginResult.Kunde, result.Result);
            Assert.IsNotNull(result.Kunde);
        }


        //Falsche Eingaben geben Failed zurück
        [TestMethod]
        public void Falsche_Daten_Sollten_Failed_Zurueckgeben()
        {
            // Arrange
            var service = new LoginService();

            // Act
            var result = service.CheckLogin("xxx", "yyy");

            // Assert
            Assert.AreEqual(LoginResult.Failed, result.Result);
        }
    }
}
