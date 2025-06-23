namespace EventosAPI.Models
{
    public class Evento
    {
        public int IdEvento { get; set; }
        public int cache { get; set; }
        public string? Status { get; set; }
        public string? GeneroPedido { get; set; }
        public TimeSpan Duracao { get; set; }
        public string? LocalEvento { get; set; }
        public TimeOnly HoraFim { get; set; }
        public TimeOnly HoraInicio { get; set; }
        public string? Endereco { get; set; }
        public string? Descricao { get; set; }
        public string? Titulo { get; set; }
        public DateOnly DtEvento { get; set; }
    }
}