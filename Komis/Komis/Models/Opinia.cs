using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Komis.Models
{
    public class Opinia
    {
        [BindNever]
        public int Id { get; set; }

        [Required(ErrorMessage ="Nazwa użytkownika jest wymagana")]
        [StringLength(25, ErrorMessage ="Nazwa użytkonika jest za długa")]
        public string NazwaUzytkownika { get; set; }

        [Required(ErrorMessage ="Adres email jest wymagany")]
        [StringLength(100, ErrorMessage ="Adres email jest za długi")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
+ "@"
+ @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$",
            ErrorMessage ="To jest niepoprawny adres email")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Tresc wiadomosci jest wymagana")]
        [StringLength(5000, ErrorMessage ="Wiadomosc jest za długa")]
        public string Wiadomosc { get; set; }

        public bool OczekujeOdpowiedzi { get; set; }

    }
}
