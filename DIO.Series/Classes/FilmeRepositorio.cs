using DIO.Series.Classes;
using DIO.Series.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DIO.Series
{
    public class FilmeRepositorio : IRepositorio<Filme>
    {
        private List<Filme> listaFilme = new List<Filme>();

        public List<Filme> Lista()
        {
            return listaFilme;
        }

        public Filme RetornaPorId(int id)
        {
            return listaFilme[id];
        }

        public void Insere(Filme obj)
        {
            listaFilme.Add(obj);
        }

        public void Exclui(int id)
        {
            listaFilme[id].Excluir();
        }

        public void Atualiza(int id, Filme obj)
        {
            listaFilme[id] = obj;
        }
        public int ProximoId()
        {
            return listaFilme.Count;
        }
    }
}
