namespace SOLID._3____L___Liskov_Substitution_Principle
{
    public class Person
    {
        public abstract string MyProfileAccount();
    }

    public class Bank
    {
        public void PegarPerfil()
        {
            Person person = new Client();
            Console.WriteLine(person.MyProfileAccount());
            Person person = new Manager();
            Console.WriteLine(person.MyProfileAccount());
        }
    }
}
