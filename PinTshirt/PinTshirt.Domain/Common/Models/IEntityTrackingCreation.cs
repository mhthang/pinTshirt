using System;

namespace PinTshirt.Domain.Common.Models
{
    public interface IEntityTrackingCreation
    {
        DateTime DateCreated { set; }
    }
}