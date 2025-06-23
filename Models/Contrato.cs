namespace EventosAPI.Models
{
    public class Contrato
    {
        public int IdContrato { get; set; }
        public int valor { get; set; }
        public string? Descricao { get; set; }
        public DateOnly DtCandidatura { get; set; }
        public string? Status { get; set; }
    }
}