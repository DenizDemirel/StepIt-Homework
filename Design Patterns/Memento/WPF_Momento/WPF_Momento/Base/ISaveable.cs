using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Momento.Base;

public interface ISaveable<TValue> {
    public TValue Save();
    public void Load(TValue momento);
}
