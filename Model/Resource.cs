using System.ComponentModel.DataAnnotations.Schema;

namespace OTP_Generator.Model
{
    public class Resource
    {
       
        static public string TempMobile { get; set; }
         static Random random = new Random();
        public static int randomNumber = random.Next(1000, 9999);
        public static string messageBody = $"Hello! Your one-time password (OTP) is: {randomNumber}. " +
            $"Keep it confidential and don't share it with anyone. Have a great day! 🌟";



    }
}
