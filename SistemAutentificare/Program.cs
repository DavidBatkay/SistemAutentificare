namespace SistemAutentificare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string username="davidbatkay";
            const string password = "ueo2023";
            string inputusername = null;
            while (inputusername != "davidbatkay")
            {
                Console.Write("Username: ");
                inputusername = Console.ReadLine();
                if (inputusername != username)
                {
                    Console.WriteLine("User nu a fost gasit! Incearca din nou");
                }
                else 
                {
                    Console.Write("Parola: ");
                    string inputpassword = Console.ReadLine();
                    if (inputpassword != password) 
                    {
                        Console.WriteLine("Parola gresita!Apasati enter");
                        Console.ReadKey();
                        Console.Clear();
                        inputusername = null; inputpassword=null;
                    }
                    else 
                    {
                        Console.WriteLine("Bine ai venit, " + username + " !");
                    }
                }
            }

        }
    }
}