using System;

namespace API_Copa.Models
{
    public class Jogo
    {
        public Jogo()
        {
            CriadoEm = DateTime.Now;
        }
        public int Id { get; set; }
        public int SelecaoAId {get; set;}
        public Selecao SelecaoA { get; set; }
        public int SelecaoBId {get; set;}
        public Selecao SelecaoB { get; set; }
        public string SelecaoA_gols {get; set;}
        public string SelecaoB_gols {get; set;}
        public DateTime CriadoEm { get; set; }
    }
}
