using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	[TLObject(153267905)]
    public class TLInputMediaPhotoExternal : TLAbsInputMedia
    {
        public override int Constructor
        {
            get
            {
                return 153267905;
            }
        }

             public int Flags {get;set;}
     public string Url {get;set;}
     public string Caption {get;set;}
     public int? TtlSeconds {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Flags = br.ReadInt32();
Url = StringUtil.Deserialize(br);
Caption = StringUtil.Deserialize(br);
if ((Flags & 1) != 0)
TtlSeconds = br.ReadInt32();
else
TtlSeconds = null;


        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            bw.Write(Flags);
StringUtil.Serialize(Url,bw);
StringUtil.Serialize(Caption,bw);
if ((Flags & 1) != 0)
bw.Write(TtlSeconds.Value);

        }
    }
}
