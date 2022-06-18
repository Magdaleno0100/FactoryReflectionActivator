using Factory.Factory.Interfaces;


namespace Factory.Factory.Implementations
{
    public class TwitterCargaDatos : ICargaDatos
    {
        public string GetLastName()
        {
            return "Nombre desde Twitter";
        }

        public string GetName()
        {
            return "Apellido desde Twitter";
        }
    }
}
