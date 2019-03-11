using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BMIApplication
{
    public interface IHaveDefaultCloseOperation<TViewObject>
    {
        ICommand CloseViewCommand { get; }
        bool     CanClose(TViewObject View);
        void     OnClose(TViewObject View);
    }
}
