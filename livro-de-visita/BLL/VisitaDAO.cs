using livro_de_visita.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace livro_de_visita.BLL
{
    interface IVisitaDAO
    {
        void Salvar(Visita v);
        List<Visita> ListarTodas();
    }

    public class VisitaDAO : IVisitaDAO
    {
        public List<Visita> ListaDeVisitas;

        public List<Visita> ListarTodas()
        {
            if (ListaDeVisitas == null)
            {
                ListaDeVisitas = new List<Visita>();
            }
            return ListaDeVisitas;
        }

        public void Salvar(Visita v)
        {
            if(ListaDeVisitas == null)
            {
                ListaDeVisitas = new List<Visita>();
            }

            ListaDeVisitas.Add(v);
        }
    }
}
