namespace ConnectlimeApi.Exercise
{
    public abstract class Customer  // base class
    {

        public string Name { get; set; } 

        public string Email { get; set; }

        public abstract int GetIdentificationNumber(); 
    }
}
