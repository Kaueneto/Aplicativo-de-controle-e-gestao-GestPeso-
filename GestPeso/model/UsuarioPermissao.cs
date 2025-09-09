using Supabase;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace GestPeso.Models
{
    [Table("usuario_permissoes")]
    public class UsuarioPermissao : BaseModel
    {
        [Column("id_usuario")]
        public long id_usuario { get; set; }

        [Column("id_permissao")]
        public long id_permissao { get; set; }
    }
}
