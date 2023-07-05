namespace ConnectlimeApi.Exercise
{
    public abstract class Customer  // base class
    {

        public string Name { get { return _name; } }

        public string Email { get; set; }

        protected string _name;

        public abstract int GetIdentificationNumber(); 
    }
}
