using Factory.Factory.Interfaces;


namespace Factory.Factory.Implementations
{
    public class FacebookCargaDatos2 : ICargaDatos
    {
        public string GetLastName()
        {
            return "Nombre desde facebook 2";
        }

        public string GetName()
        {
            return "Apellido desde Facebook 2";
        }
    }
}
