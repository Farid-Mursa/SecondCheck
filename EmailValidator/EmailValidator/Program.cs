namespace EmailValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmailValidator emailValidator = new EmailValidator();
            Console.WriteLine("Please type your mail");
            string mail= Console.ReadLine();
            try
            {
                bool isValid = emailValidator.Validate(mail);
                Console.WriteLine(isValid);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}