//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaVendas
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_produto
    {
        internal string codigo;

        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public Nullable<decimal> Valor { get; set; }
        public Nullable<int> CodigoCategoria { get; set; }
    
        public virtual Categoria tb_categoria { get; set; }
    }
}
