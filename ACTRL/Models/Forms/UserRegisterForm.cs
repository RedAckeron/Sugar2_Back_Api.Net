using System.ComponentModel.DataAnnotations;

namespace ACTRL.Models.Forms
{
	public class UserRegisterForm
	{
        [Required(ErrorMessage = "Le champ Email est obligatoire")]
        [RegularExpression("^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$", ErrorMessage = "Votre Mail ne correspond pas au format attendu")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Le champ Password est obligatoire")]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage = "Votre password ne correspond pas au format attendu")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Le champ Prénom est obligatoire")]
        [RegularExpression("[a-zA-Z]{2,}", ErrorMessage = "Votre prénom dois faire au moins 2 characteres")]
        public string FirsName{ get; set; }
        
        [Required(ErrorMessage = "Le champ Nom est obligatoire")]
        [RegularExpression("[a-zA-Z]{2,}", ErrorMessage = "Votre nom dois faire au moins 2 characteres")]
        public string LastName { get; set; }
    }
}
