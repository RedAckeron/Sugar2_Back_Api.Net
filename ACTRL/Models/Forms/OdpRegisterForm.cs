using System.ComponentModel.DataAnnotations;

namespace ACTRL.Models.Forms
{
	public class OdpRegisterForm
	{
        [Required(ErrorMessage = "Le champ AddByUser est obligatoire")]
        public int AddByUser { get; set; }
        
        [Required(ErrorMessage = "Le champ IdCustomer est obligatoire")]
        public int IdCustomer { get; set; }

       
    }
}
