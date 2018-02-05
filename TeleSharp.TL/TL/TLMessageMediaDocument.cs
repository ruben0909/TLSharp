using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	[TLObject(2084836563)]
    public class TLMessageMediaDocument : TLAbsMessageMedia
    {
        public override int Constructor
        {
            get
            {
                return 2084836563;
            }
        }

             public int Flags {get;set;}
     public TLAbsDocument Document {get;set;}
     public string Caption {get;set;}
     public int? TtlSeconds {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Flags = br.ReadInt32();
if ((Flags & 1) != 0)
Document = (TLAbsDocument)ObjectUtils.DeserializeObject(br);
else
Document = null;

if ((Flags & 2) != 0)
Caption = StringUtil.Deserialize(br);
else
Caption = null;

if ((Flags & 4) != 0)
TtlSeconds = br.ReadInt32();
else
TtlSeconds = null;


        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            bw.Write(Flags);
if ((Flags & 1) != 0)
ObjectUtils.SerializeObject(Document,bw);
if ((Flags & 2) != 0)
StringUtil.Serialize(Caption,bw);
if ((Flags & 4) != 0)
bw.Write(TtlSeconds.Value);

        }
    }
}
