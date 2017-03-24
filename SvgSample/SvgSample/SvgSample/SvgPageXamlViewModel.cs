using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SvgSample
{
    public class SvgPageXamlViewModel
    {
        public Assembly SvgAssembly
        {
            get { return typeof(App).GetTypeInfo().Assembly; }
        }

        public string AppStorePath
        {
            get { return "SvgSample.Resources.AppStore.svg"; }
        }
        public string CoolMaskPath
        {
            get { return "SvgSample.Resources.CoolMask.svg"; }
        }
        public string TigerPath
        {
            get { return "SvgSample.Resources.Tiger.svg"; }
        }
    }
}
