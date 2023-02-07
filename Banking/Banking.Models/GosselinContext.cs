using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Models
{
    public class GosselinContext:IDisposable
    {
        public static GosselinContext? Context { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsConnected { get; set; }

        private GosselinContext() { }


        public void Connect() { 
            IsConnected = true;
        }

        public void Disconnect()
        {
            IsConnected = false;
        }

        public void Dispose()
        {
          IsConnected= false;
        }

        public static GosselinContext CreateContext() {
            if (Context == null) Context = new GosselinContext();
            return Context;
        }
    }
}
