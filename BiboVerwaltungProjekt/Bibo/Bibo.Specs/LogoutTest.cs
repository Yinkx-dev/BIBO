using Bibo.Models;
using Bibo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibo.Tests
{
    [TestClass]
    public sealed class LogoutTest
    {
        //Logout setzt CurrentKunde zurück
        [TestMethod]
        public void Logout_Sollte_CurrentKunde_Resetten()
        {
            // Arrange
            Globals.CurrentKunde = new Kunde { KundenID = 123 };

            var service = new SessionService();

            // Act
            service.Logout();

            // Assert
            Assert.AreEqual(0, Globals.CurrentKunde.KundenID);
        }
    }
}