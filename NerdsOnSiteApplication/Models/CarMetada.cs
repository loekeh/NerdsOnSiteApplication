using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NerdsOnSiteApplication.Models
{
    [MetadataType(typeof(Car.Metadata))]
    
    public partial class Car
    {       
            sealed class Metadata
            {

                public int CarId { get; set; }
                [Required]
                [Display(Name = "Car Manufacturer")]
                public string CarManufacturer { get; set; }

                [Required]
                [Display(Name = "Car Make")]
                public string CarMake { get; set; }

                [Required]
                [Display(Name = "Year Of Car")]
                public System.DateTime CarYear { get; set; }

               [Required]
               [Display(Name = "Color Of Car")]
                public string Color { get; set; }
               [Required]
               [Display(Name = "Passenger Seating")]
                public int PassengerSeating { get; set; }
            }
        }
    }

