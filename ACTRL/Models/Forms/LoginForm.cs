using System.ComponentModel.DataAnnotations;

namespace ACTRL.Models.Forms
{
	public class LoginForm
	{
        [Required(ErrorMessage = "Le champ Email est obligatoire")]
        [RegularExpression("^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$", ErrorMessage = "Votre Mail ne correspond pas au format attendu")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Le champ Password est obligatoire")]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage = "Votre password ne correspond pas au format attendu")]
        public string Password { get; set; }
    }
}
