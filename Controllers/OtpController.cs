using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OTP_Generator.Model;
using OTP_Generator.Model.data;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace OTP_Generator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OtpController : ControllerBase
    {
        private readonly OtpDbContext _context;
        private readonly IConfiguration _configuration;
        public OtpController(OtpDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
       
       

        [HttpGet("{mobile}")]
        public async Task<IActionResult> Message(string mobile)
        {
            Resource.TempMobile = mobile;
            var result = await _context.Users.FirstOrDefaultAsync(p => p.MobileNo == mobile);
            if(result == null)
            {
                if(Otp(mobile) != true)
                {
                    return Ok("There is problem with sending otp!");
                }
               

                return Ok("Otp is sent successfully!");
            }


            return Ok("You already have an account");
        }

        [HttpPost()]
        public async Task<IActionResult> Verify([FromBody] int otp)
        {
            if(Resource.randomNumber == otp)
            {
                User user = new User();
                user.MobileNo = Resource.TempMobile;
                
                await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();
                return Ok("Thank you for registering with us");
            }
            return Ok("Invalid Otp");
        }
        private  bool Otp(string mobile)
        {


            try
            {
                string secret = _configuration["Twillio:secret"];
                string token = _configuration["Twillio:token"];
                string PhNumber = _configuration["Twillio:PhNumber"];
                TwilioClient.Init(secret, token);
                var message = MessageResource.Create(
                    body: Resource.messageBody,
                    from: new Twilio.Types.PhoneNumber(PhNumber),
                    to: new Twilio.Types.PhoneNumber("+91" + mobile)
                    );
                return true;
            }
            catch (Exception)
            {
                return false;
                //throw;
            }
          

            
        }

        
    }
}
