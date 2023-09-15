using System.ComponentModel.DataAnnotations;

namespace ACTRL.Models.Forms
{
	public class AddressForm
	{
        public int Id { get; set; } = 0;
        
        [Required(ErrorMessage = "Le champ info est obligatoire")]
        [RegularExpression("[a-zA-Z]{2,}", ErrorMessage = "Le champ info dois faire au moins 2 characteres")]
        public string AdrInfo { get; set; }
        
        [Required(ErrorMessage = "Le champ rue est obligatoire")]
        [RegularExpression("[a-zA-Z]{2,}", ErrorMessage = "Le champ rue dois faire au moins 2 characteres")]
        public string AdrRue { get; set; }
        
        [Required(ErrorMessage = "Le champ no est obligatoire")]
        [RegularExpression("[a-zA-Z0-9]{2,}", ErrorMessage = "Le champ no dois faire au moins 2 characteres")]
        public string AdrNo { get; set; }
        
        [Required(ErrorMessage = "Le champ ville est obligatoire")]
        [RegularExpression("[a-zA-Z]{2,}", ErrorMessage = "Le champ ville dois faire au moins 2 characteres")]
        public string AdrVille { get; set; }
        
        [Required(ErrorMessage = "Le champ code postal est obligatoire")]
        [RegularExpression("[a-zA-Z0-9]{2,}", ErrorMessage = "Le champ code postal dois faire au moins 2 characteres")]
        public string AdrCp { get; set; }
        
        [Required(ErrorMessage = "Le champ pays est obligatoire")]
        [RegularExpression("[a-zA-Z]{2,}", ErrorMessage = "Le champ pays dois faire au moins 2 characteres")]
        public string AdrPays { get; set; }

    }
}
