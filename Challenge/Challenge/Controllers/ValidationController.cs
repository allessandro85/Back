
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProyectBack.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ValidationController
    {
        [HttpGet]
        [AllowAnonymous]
        public string GetValidationName(string name, string surname)
        {
            var resultadoGral = false;
            var resultadoNombre = Services.Validator.Verificar(name);
            var resultadoApellido = Services.Validator.Verificar(surname);

            if(resultadoNombre && resultadoApellido)
            {
                resultadoGral = true;
            }
            return resultadoGral.ToString();
        }   
    }
}