using Microsoft.AspNetCore.Mvc;
using Selu383.SP25.P03.Api.Features.Payment;
using Stripe;

namespace Selu383.SP25.P03.Api.Controllers
{
    [Route("api/payment")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IConfiguration _config;

        public PaymentController(IConfiguration config)
        {
            _config = config;
            StripeConfiguration.ApiKey = _config["Stripe:SecretKey"];
        }

        [HttpPost("create-payment-intent")]
        public async Task<IActionResult> CreatePaymentIntent([FromBody] PaymentRequest request)
        {
            var options = new PaymentIntentCreateOptions
            {
                Amount = (long)(request.Amount * 100), 
                Currency = "usd",
                Description = request.Description
            };

            var service = new PaymentIntentService();
            var intent = await service.CreateAsync(options);

            return Ok(new { clientSecret = intent.ClientSecret });
        }
    }
}
