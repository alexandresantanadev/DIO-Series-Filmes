using DIO.Series.Classes;
using DIO.Series.Interfaces;
using System;
using System.Collections.Generic;

namespace DIO.Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        public List<Serie> Lista()
        {
            return listaSerie;
        }
        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
        public void Insere(Serie obj)
        {
            listaSerie.Add(obj);
        }
        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }
        public void Atualiza(int id, Serie obj)
        {
            listaSerie[id] = obj;
        }
        public int ProximoId()
        {
            return listaSerie.Count;
        }
    }
}
