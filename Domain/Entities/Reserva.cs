namespace Domain.Entities
{
    public class Reserva
    {
        public int Id { get; set; }
        public string Local { get; set; }
        public string Sala { get; set; }
        public DateTime DataHorainicio { get; set; }
        public DateTime DataHoraFinal { get; set; }
        public string Responsavel { get; set; }
        public bool Cafe { get; set; }
        public string Descricao { get; set; }

    }
}
