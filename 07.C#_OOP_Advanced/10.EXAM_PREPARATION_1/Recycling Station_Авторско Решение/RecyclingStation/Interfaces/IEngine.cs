using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecyclingStation.Interfaces
{
    using RecyclingStation.Interfaces.UI;

    public interface IEngine : IRunnable
    {
        ICommandHandler CommandHandler { get; }

        IReader Reader { get;  }

        IWriter Writer { get;  }
    }
}
