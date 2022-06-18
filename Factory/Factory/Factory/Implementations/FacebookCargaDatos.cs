using Factory.Factory.Interfaces;


namespace Factory.Factory.Implementations
{
    public class FacebookCargaDatos : ICargaDatos
    {
        public string GetLastName()
        {
            return "Nombre desde facebook";
        }

        public string GetName()
        {
            return "Apellido desde Facebook";
        }
    }
}
