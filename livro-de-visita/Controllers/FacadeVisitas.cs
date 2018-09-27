using System.Collections.Generic;
using livro_de_visita.BLL;
using livro_de_visita.Models;

namespace livro_de_visita.Controllers
{
    public  class FacadeVisitas 
    {
        public VisitaDAO visitaDao = new VisitaDAO();

        public List<Visita> ListarTodas()
        {
            return visitaDao.ListarTodas();
        }

        public void Salvar(Visita v)
        {
            visitaDao.Salvar(v);
        }
    }
}