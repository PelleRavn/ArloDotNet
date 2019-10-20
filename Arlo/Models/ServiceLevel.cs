using System;
using System.Collections.Generic;

namespace Arlo.Models
{
    public class ServiceLevelPlan
    {
    }

    public class ServiceLevel
    {
        public List<ServiceLevelPlan> Plans { get; set; }
    }
}
