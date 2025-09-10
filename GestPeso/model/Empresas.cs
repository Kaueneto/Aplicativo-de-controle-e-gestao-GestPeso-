using Supabase.Postgrest.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supabase.Postgrest.Models;

namespace GestPeso.model
{
    [Table("empresas")]
    public class Empresas : BaseModel
    {
        [Column("id")]
        public long id { get; set; }

        [Column("codigo")]
        public string codigo { get; set; }

        [Column("nome")]
        public string nome { get; set; }
    }
}
