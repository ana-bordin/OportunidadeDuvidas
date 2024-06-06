using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Oportunidade
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataEntrega { get; set; }
        public string NivelSurto { get; set; }
        public int QtdHora { get; set; }
        public long QtdErro { get; set; }
        public long NivelAprendizado { get; set; }
        public short HorasSono { get; set; }
        public short HorasFolga { get; set; }
    }
}
