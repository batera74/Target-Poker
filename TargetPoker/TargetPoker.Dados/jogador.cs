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
    
    public partial class jogador
    {
        public jogador()
        {
            this.torneio_jogador = new HashSet<torneio_jogador>();
        }
    
        public int id_jogador { get; set; }
        public string nm_jogador { get; set; }
        public string nm_sobrenome_jogador { get; set; }
        public System.DateTime dt_nascimento { get; set; }
        public string ds_email { get; set; }
        public string ds_imagem { get; set; }
        public bool ic_target_team { get; set; }
    
        public virtual ICollection<torneio_jogador> torneio_jogador { get; set; }
    }
}