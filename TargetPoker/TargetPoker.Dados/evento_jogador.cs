//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TargetPoker.Dados
{
    using System;
    using System.Collections.Generic;
    
    public partial class evento_jogador
    {
        public int id_evento { get; set; }
        public int id_jogador { get; set; }
        public int ds_posicao_evento { get; set; }
        public int qt_pontos { get; set; }
    
        public virtual jogador jogador { get; set; }
        public virtual evento evento { get; set; }
    }
}
