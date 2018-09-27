using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Listagem.Models
{
    [DataTable("Listagem")]
    public class Lista
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string End { get; set; }
        public string Email { get; set; }
        public double Telefone { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [Version]
        public string Version { get; set; }
    }
}
