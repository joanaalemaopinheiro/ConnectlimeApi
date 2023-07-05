namespace ConnectlimeApi.Exercise
{
    public sealed class Company : Customer
    {

        private readonly int NIPC;

        public override int GetIdentificationNumber()
        {
            return NIPC;
        }


        public Company(string email, string name, int nipc)
        {
            Email = email;
            Name = name; 
            NIPC = nipc;
        }
    }

}
