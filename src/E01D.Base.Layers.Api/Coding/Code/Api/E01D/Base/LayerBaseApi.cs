using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Root.Coding.Code.Api.E01D.Base.Layers;

namespace Root.Coding.Code.Api.E01D.Base
{
    public class LayerBaseApi
    {
        public BasicLayerApi Basic { get; set; } = new BasicLayerApi();
    }
}
