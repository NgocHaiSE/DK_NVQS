using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DK_NVQS.ViewModel
{
    public class RegistrationVM
    {
        public string CitizenID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Hometown { get; set; }
    }
}