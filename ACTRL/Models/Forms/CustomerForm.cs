using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTRL.Models

{
    public class CustomerForm
    {
        [Required(ErrorMessage = "Le champ Prénom est obligatoire")]
        [RegularExpression("[a-zA-Z]{2,}", ErrorMessage = "Votre prénom dois faire au moins 2 characteres")]
        public string FirstName { get; set; }
        
        [Required(ErrorMessage = "Le champ Prénom est obligatoire")]
        [RegularExpression("[a-zA-Z]{2,}", ErrorMessage = "Votre prénom dois faire au moins 2 characteres")]
        public string LastName { get; set; }
        
        [RegularExpression("^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$", ErrorMessage = "Votre Mail ne correspond pas au format attendu")]
        public string Email { get; set; }

        [RegularExpression("[a-zA-Z0-9]{2,20}", ErrorMessage = "Le call1 n est pas conforme")]
        public string Call1 { get; set; }
        
        [RegularExpression("[a-zA-Z0-9]{2,20}", ErrorMessage = "Le call2 n est pas conforme")]
        public string Call2 { get; set; }

        [Required(ErrorMessage = "AddByUser est manquant")]
        [RegularExpression("[0-9]{1,}", ErrorMessage = "AddByUser n est pas valide")]
        public int AddByUser { get; set; }
        public DateTime DtIn{ get; set; }

    }
}