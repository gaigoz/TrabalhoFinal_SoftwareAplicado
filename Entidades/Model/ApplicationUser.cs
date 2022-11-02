using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Entidades.Model
{
    // classe herda do IdentityFramework
    public class ApplicationUser : IdentityUser
    {
        [MaxLength(50)]
        [Display(Name = "CPF")]
        public string CPF { get; set; }

        [MaxLength(40)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }


        [MaxLength(9)]
        [Display(Name = "CEP")]
        public string CEP { get; set; }


        [MaxLength(255)]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }
    }
}
