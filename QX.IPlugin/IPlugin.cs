using System;
using System.Collections.Generic;
using System.Text;

namespace QX.PluginFramework
{
    public interface IPlugin 
    {
        IApplication Application { get;set;}
        String Name { get;set;}
        String Description { get;set;}
        String Data { get; set; }
        void Load();
        void UnLoad();

        event EventHandler<EventArgs> Loading;
    }
}
