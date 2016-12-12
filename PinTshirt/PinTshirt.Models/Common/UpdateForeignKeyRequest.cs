using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinTshirt.Models.Common
{
    public class UpdateForeignKeyRequest
    {
        public Guid PrimaryKeyId { get; set; }
        public Guid? ForeignKeyId { get; set; }
    }
}
