using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarRentalSystem.Models
{
    [MetadataType(typeof(carregMetadata))]
    public partial class carreg
    {
        public class carregMetadata
        {
            [DisplayName("Car no. ")]
            public string carno { get; set; }
            [DisplayName("Brand ")]
            public string make { get; set; }
            [DisplayName("Model ")]
            public string model { get; set; }
            [DisplayName("Availability ")]
            public string available { get; set; }    
        }
    }
}