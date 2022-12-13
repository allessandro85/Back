
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProyectBack.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class FractionsController 
    {
        
        [HttpGet]
        [AllowAnonymous]
        public string GetFractionSimplify(int numerador, int denominador)
        {
            return Services.Fractions.GetFractionSimplify(numerador, denominador);
        } 
    }
}