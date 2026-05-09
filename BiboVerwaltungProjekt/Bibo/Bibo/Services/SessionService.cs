using Bibo.Models;

namespace Bibo.Services
{
    public class SessionService
    {
        public void Logout()
        {
            Globals.CurrentKunde = new Kunde();
        }
    }
}
