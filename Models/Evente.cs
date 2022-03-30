using System.ComponentModel.DataAnnotations;

namespace NdihmesTagLaborator.Models
{
    public class Evente
    {
      
            public int Id { get; set; }
            [Required(ErrorMessage = "Emri duhet te plotesohet")]
            [StringLength(255, ErrorMessage = "Emri duhet midis 3-255 karaktere", MinimumLength = 3)]
            public string? Emri { get; set; }
            [EmailAddress]
            [Required(ErrorMessage = "Email duhet te plotesohet")]
            public string? Email { get; set; }
            [Required(ErrorMessage = "Tel duhet te plotesohet")]
            public string? Tel { get; set; }
            [Required(ErrorMessage = "Konfirmimi duhet te plotesohet")]
            public bool? Konfirmim { get; set; }
        
    }
}
