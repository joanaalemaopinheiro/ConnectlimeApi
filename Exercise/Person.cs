using System.Security.Cryptography;

namespace ConnectlimeApi.Exercise
{
    public sealed class Person : Customer 
    {

        private readonly int NIF;
        public override int GetIdentificationNumber()
        {
            return NIF;
        }


        public Person(string email, string name, int nif)
        {
            Email = email;
            _name = name;
            NIF = nif;
        }
    }

}
