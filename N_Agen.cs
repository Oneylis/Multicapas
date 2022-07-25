using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;

namespace Negocio
{
    public class N_Agen
    {
        D_Agen objDato = new D_Agen();
        public List<E_Agen> ListarAgenda (String buscar)
        {
            return objDato.ListarAgenda(buscar);    
        }
        public void InsertAgenda (E_Agen Agenda)
        {
            objDato.Insertaragenda(Agenda);
        }
        public void editarAgenda(E_Agen Agenda)
        {
            objDato.EditarAgenda(Agenda);
        }
        public void EliminarAgenda(E_Agen Agenda)
        {
            objDato.EliminarAgenda(Agenda);
        }
    }
}
