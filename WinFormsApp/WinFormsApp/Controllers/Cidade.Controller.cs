using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.DBContext;
using WinFormsApp.Entidades;

namespace WinFormsApp.Controllers
{
    public class CidadeController
    {
        public CidadeController() { }

       public int  RetornaProximoId()
        {
            BDContexto bd = new BDContexto();
            int registro = bd.Cidades.OrderBy(p=>p.id).Select(p=>p.id).LastOrDefault();
            return registro + 1;
        }
        public bool AddCidade(Cidades cidade)
        {
            BDContexto bd = new BDContexto();
            bd.Cidades.Add(cidade);
            bd.SaveChanges();
           
            return true;
        }

        public List<Cidades> CarregaGridCidades()
        {
           DataSet dataSet = new DataSet();
     
           BDContexto bd = new BDContexto();
           var listaDeCidades = bd.Cidades.ToList();
            return listaDeCidades;
        }

        public bool EditCidade(Cidades c)
        {
            BDContexto bd = new BDContexto();
            var registro = bd.Cidades.Find(c.id);
         
            if (registro != null)
            {
                registro.nome = c.nome;
              

                bd.SaveChanges();
              
                return true;
             

            } else { return false; }
        }

        public List<Cidades> buscaCidade(int id)
        {
            BDContexto bd = new BDContexto();
            var listaCidades =  bd.Cidades.Where(c => c.id == id).ToList();

            return listaCidades;

        }


        public bool DeleteCidade(int registro)
        {
          try
            {
               BDContexto bd = new BDContexto();
               var codigoExcluir = bd.Cidades.Find(registro);

                if (codigoExcluir != null)
               {
                  bd.Cidades.Remove(codigoExcluir);
                  bd.SaveChanges();

                  return true;
                 
               } else
               {
                    return false;
               }
            }
            catch (Exception)
            {
                return false;

            }
        }




    }
}
