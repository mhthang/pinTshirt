using System;

namespace PinTshirt.Domain.Common.Models
{
    public interface IEntityTrackingModified
    {
        DateTime DateModified { set; }
    }
}