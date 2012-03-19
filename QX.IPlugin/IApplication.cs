using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.Design;
using System.Windows.Forms;

namespace QX.PluginFramework
{
    public interface IApplication:IServiceContainer
    {
        Panel LeftToolPanel { get;}
        Panel RightToolPanel { get; }
        Panel TopToolPanel { get; }
        Panel BottomToolPanel { get; }

        MenuStrip MainMenuStrip { get;}
        StatusStrip StatusBar { get;}        
    }
}
