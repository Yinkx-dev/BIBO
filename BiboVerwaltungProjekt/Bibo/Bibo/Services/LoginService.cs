using Bibo.Models;

namespace Bibo.Services
{
    public class LoginService
    {
        public LoginResponse CheckLogin(string username, string password)
        {
            //Checken, ob Admin einloggt
            var personal = Globals.Db.QuerySingle<Personal>("SELECT * FROM Personal");

            if (username == personal.Nutzername && password == personal.Kennwort)
                return new LoginResponse
                {
                    //Ergebnis: Personal
                    Result = LoginResult.Personal
                };


            //Checken, ob Kunde einloggt
            var kunde = Globals.Db.QuerySingle<Kunde>(
                "SELECT * FROM Kunde WHERE Nutzername = @username AND Passwort = @password",
                new { username, password }
            );

            if (kunde != null)
                return new LoginResponse
                {
                    //Ergebnis: Kunde mit Kundendaten
                    Result = LoginResult.Kunde,
                    Kunde = kunde
                };


            //Login-Daten falsch
            return new LoginResponse
            {
                //Ergebnis: Nutzer nicht vorhanden
                Result = LoginResult.Failed
            };
        }
    }
}
