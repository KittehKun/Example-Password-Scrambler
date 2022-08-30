namespace Example_Password_Scrambler.classes
{
    public class Scrambler
    {
        private string? password;
        private char[]? charPassword;
        private Random random = new Random();
        
        public void ScramblePassword()
        {
            Console.Clear();
            Console.WriteLine("Input a password to scramble:\n");
            string? input = Console.ReadLine();
            if(!string.IsNullOrEmpty(input))
            {
                this.password = input;
                this.charPassword = password.ToCharArray();
                this.charPassword = this.charPassword.OrderBy(element => random.Next()).ToArray();
                this.password = new string(this.charPassword);
                Console.WriteLine($"\nThe scrambled password is: {this.password}\n");
            } else
            {
                Console.WriteLine("Password cannot be empty. Please input a password to scramble:\n");
                ScramblePassword();
            }
        }
    }
}