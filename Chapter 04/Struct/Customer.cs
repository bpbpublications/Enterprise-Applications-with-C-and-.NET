namespace Struct
{
    public struct Customer
    {
        public Customer(int id, string name, DateTime birthDay)
        {
            this.Name = name;
            this.BirthDay = birthDay;
            this.Id = id;

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
    }
}
