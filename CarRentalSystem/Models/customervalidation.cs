﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarRentalSystem.Models
{
    [MetadataType(typeof(customerMetaData))]
    public partial class customer
    {
        public class customerMetaData
        {
            [DisplayName("Customer Name ")]
            public string custname { get; set; }
            [DisplayName("Customer Address ")]
            public string address { get; set; }
            [DisplayName("Customer Mobile# ")]
            public string mobile { get; set; }
        }
    }
}