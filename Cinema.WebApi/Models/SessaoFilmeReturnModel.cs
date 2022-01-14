namespace Cinema.WebApi.Models
{
    public class SessaoFilmeReturnModel
    {
        public string NomeFilme { get; set; }

        public string Data { get; set; }

        public string Hora { get; set; }

        public int QuantidadeDisponivel { get; set; }

        public float ValorIngresso { get; set; }

    }
}
