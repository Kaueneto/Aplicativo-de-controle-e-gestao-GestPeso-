using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestPeso
{
    // Modelo da tabela usuarios
    [Table("usuarios")]
    public class Usuario : BaseModel
    {
        [PrimaryKey("id_usuario")]
        public long id_usuario { get; set; }

        [Column("codigo_usuario")]
        public string codigo_usuario { get; set; }

        [Column("nome")]
        public string nome { get; set; }

        [Column("senha_hash")]
        public string senha_hash { get; set; }

        [Column("id_empresa")]
        public long id_empresa { get; set; }

        [Column("dt_cadastro_usuario")]
        public DateTime dt_cadastro_usuario { get; set; }

    }
}
