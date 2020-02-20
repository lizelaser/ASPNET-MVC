using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class PersonalBL : Repositorio<DA.Personal>
    {
        public static List<PersonalVm> ListarPersonalVm()
        {
            using (var db = new DA.DAEntities())
            {
                var qry = from c in db.Personal
                          join t in (db.ValorTabla.Where(x => x.TablaId == Constante.ValorTabla.TipoPersonal)) on c.TipoPersonalId equals t.ItemId
                          select new PersonalVm
                          {
                              Id = c.Id,
                              Dni = c.Dni,
                              Nombres = c.Paterno + " " + c.Materno + " " + c.Nombres,
                              Celular = c.Celular,
                              Correo = c.Correo,
                              Estado = c.Estado,
                              TipoPersonal = t.Denominacion
                          };
                return qry.ToList();
            }

        }
    }
}
