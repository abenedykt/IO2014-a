using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac.Extras.DynamicProxy2;

namespace Io_Aspekty.Models
{
    [Intercept(typeof(MyInterceptor))]
    public interface ISomeModel
    {
        string[] Method();
    }
}
