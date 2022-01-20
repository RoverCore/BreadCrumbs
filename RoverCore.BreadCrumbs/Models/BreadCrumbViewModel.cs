using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverCore.BreadCrumbs.Models
{
    public class BreadCrumbViewModel
    {
        public BreadCrumb Home { get; set; } = new BreadCrumb();
        public List<BreadCrumb>? Intermediate { get; set; }
        public BreadCrumb? Current { get; set; }
    }
}
