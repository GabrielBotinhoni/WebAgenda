using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebAgenda.Domain.Entities
{
    public class Contact
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "O campo Primeiro Nome é obrigatório")]
        [DisplayName("Primeiro Nome")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "O campo Sobrenome é obrigatório")]
        [DisplayName("Sobrenome")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "O campo Telefone é obrigatório")]
        [DisplayName("Telefone")]
        public string PhoneNumber { get; set; }
        [DisplayName("Email")]
        [EmailAddress(ErrorMessage ="Email Inválido")]
        public string Email { get; set; }
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido, tente 'DD/MM/AAAA'")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DisplayName("Data de Nascimento")]
        public DateTime BirthDate { get; set; }
    }
}
