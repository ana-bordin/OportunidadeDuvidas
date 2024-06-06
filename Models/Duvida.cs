using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Duvida
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataDuvida { get; set; }
    }
}
