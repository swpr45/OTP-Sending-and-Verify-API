using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OTP_Generator.Model
{
    public class User
    {
        //public int Id { get; set; }
        [Key]
       
        public string MobileNo { get; set; }

        
    }
}
