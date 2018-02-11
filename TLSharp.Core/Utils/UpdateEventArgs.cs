using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;

namespace TLSharp.Core.Utils
{
    public class UpdateEventArgs : EventArgs
    {
        public ulong MessageId;
        public int Sequence;
        public TLVector<TLAbsUpdate> Updates;
        
    }
}
