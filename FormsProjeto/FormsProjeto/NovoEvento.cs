using System;
using System.Collections.Generic;
using System.Text;

namespace FormsProjeto
{
    public class ItemCarrinho
    {
        public string Categoria { get; set; } 
        public string SubCategoria { get; set; } 
        public int ID_Catalogo { get; set; } 
        public string Descricao { get; set; } 

        public int Horas { get; set; }
        public int Animadores { get; set; }
        public int Sessoes { get; set; }
        public string AlturaDia { get; set; }
        public decimal PrecoUnitario { get; set; }
        public int ParticipantesEvento { get; set; }

        public decimal SubTotal
        {
            get
            {
                if (Categoria == "Música") return PrecoUnitario * Horas;
                if (Categoria == "Fotografia") return PrecoUnitario * Sessoes;
                if (Categoria == "Animação") return PrecoUnitario;
                if (Categoria == "Catering") return PrecoUnitario * ParticipantesEvento;
                return PrecoUnitario;
            }
        }
    }
    public class NovoEvento
    {
        public string ClienteNIF { get; set; }
        public string ClienteNome { get; set; }


        public int ID_Local { get; set; }
        public string NomeLocal { get; set; }
        public int ID_Tipo { get; set; }
        public string NomeTipo { get; set; }
        public int Participantes { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int DuracaoHoras { get; set; }
        public decimal Preco { get; set; }

        public List<ItemCarrinho> AtividadesEscolhidas { get; set; } = new List<ItemCarrinho>();

        public decimal PrecoTotalFinal
        {
            get
            {
                decimal somaAtividades = 0;
                foreach (var item in AtividadesEscolhidas) { somaAtividades += item.SubTotal; }
                return Preco + somaAtividades;
            }
        }
    }
}
