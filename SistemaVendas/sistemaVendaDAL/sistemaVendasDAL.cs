using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas.sistemaVendaDAL
{
     public class sistemaVendasDAL
    {
        public tb_produto consultarPorCodigo(string codigo)
        {
            using (db_sistemaVendasEntities ctx = new db_sistemaVendasEntities())
            {
                return ctx.tb_produto.Where(c => c.codigo == codigo).FirstOrDefault();
            }
        } 

        public void cadastrarProduto (tb_produto cadastroProd)
        {
            using (db_sistemaVendasEntities ctx = new db_sistemaVendasEntities())
            {
                ctx.tb_produto.Add(cadastroProd);
                ctx.SaveChanges();
            }
        }
    }
}
