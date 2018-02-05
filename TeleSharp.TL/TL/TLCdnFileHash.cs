using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	[TLObject(2012136335)]
    public class TLCdnFileHash : TLObject
    {
        public override int Constructor
        {
            get
            {
                return 2012136335;
            }
        }

             public int Offset {get;set;}
     public int Limit {get;set;}
     public byte[] Hash {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Offset = br.ReadInt32();
Limit = br.ReadInt32();
Hash = BytesUtil.Deserialize(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            bw.Write(Offset);
bw.Write(Limit);
BytesUtil.Serialize(Hash,bw);

        }
    }
}
