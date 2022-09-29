using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP
{
    public interface ICollection
    {
        List<Model.Camera> LoadCollection();
    }
}
