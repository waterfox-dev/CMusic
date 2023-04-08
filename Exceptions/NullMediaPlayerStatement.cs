using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMusic.Exceptions
{
    class NullMediaPlayerStatement : Exception
    {
        public NullMediaPlayerStatement() : base("MediaPlayer return a null value")
        { }
    }
}
