using System;
using System.Collections.Generic;


namespace CadastroSeries
{
    public class SerieRepositorio : IRepositorio<Series>
    {
        private List<Series> listaSerie = new List<Series>();
        public void Atualizar(int id, Series entidade)
        {
            listaSerie[id] = entidade;
        }

        public void Excluir(int id)
        {
            listaSerie[id].Exclui();
        }

        public void Insert(Series entidade)
        {
            listaSerie.Add(entidade);
        }

        public List<Series> Lista()
        {
           return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Series retornaPorID(int id)
        {
           return listaSerie[id];
        }
    }
}