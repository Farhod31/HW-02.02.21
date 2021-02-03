using System;

namespace hw_02_02._21
{
    class Program
    {
        static void Main(string[] args)
        {
            int Id = Convert.ToInt32(Console.ReadLine());
            string FirstName = Console.ReadLine();
            string LastName = Console.ReadLine();
            string MiddleName = Console.ReadLine();
            string Hobbies = Console.ReadLine();
            Descriptions one = new Descriptions(Id, FirstName, LastName, MiddleName, Hobbies);
            one.Description();
        }
    }
    class Descriptions
    {
        public int Id;
        public string FirstName;
        public string LasteName;
        public string MiddleName;
        public string Hobbies;

        public Descriptions(int Id, string FirstName, string LastName, string MiddleName, string Hobbies)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LasteName = LasteName;
            this.MiddleName = MiddleName;
            this.Hobbies = Hobbies;
        }
        public void Description()
        {
            Console.WriteLine($"Id: {Id}, \n FirstName:{FirstName}, \n LastName:{LasteName}, \n MiddleName: {MiddleName}, \n Hobbies: {Hobbies} ");
        }
    }

}
