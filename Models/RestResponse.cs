using System;
using System.ComponentModel.DataAnnotations;

namespace Mike04.Models
{
    public class RestResponse
    {
        [Required(ErrorMessage = "Name Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Restaurant Name Required")]
        public string RestName { get; set; }
        [Required(ErrorMessage = "Favorite Dish Required")]
        public string RestDish { get; set; }
        [Required(ErrorMessage = "Phone Number Required")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string RestPhone { get; set; }
        public string? RestAddress { get; set; } = "NA";
        public string? RestLink { get; set; } = "NA";

    }
}
