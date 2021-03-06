﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; // Entity freamwork, kako bi mogli [requied na polja staviti]

namespace BusinessLayer
{
    public interface IEmployee
    {
        int ID { get; set; }
        string Gender { get; set; }
        string City { get; set; }
        DateTime? DateOfBirth { get; set; }
    }
    public class Employee : IEmployee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [Required] // pojavit ce se greška da je polje obvezno
        public string Gender { get; set; }
        [Required] // neće dopustiti null iz forme, morat će se povuć podaci
        public string City { get; set; }
        [Required]
        public DateTime? DateOfBirth { get; set; }

        //ovo je testni komentar za Git
    }
}
