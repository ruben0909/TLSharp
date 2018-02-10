using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Account
{
	[TLObject(353818557)]
    public class TLRequestSendConfirmPhoneCode : TLMethod
    {
        public override int Constructor
        {
            get
            {
                return 353818557;
            }
        }

                public int Flags {get;set;}
        public bool AllowFlashcall {get;set;}
        public string Hash {get;set;}
        public bool? CurrentNumber {get;set;}
        public Auth.TLSentCode Response{ get; set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Flags = br.ReadInt32();
AllowFlashcall = (Flags & 1) != 0;
Hash = StringUtil.Deserialize(br);
if ((Flags & 1) != 0)
CurrentNumber = BoolUtil.Deserialize(br);
else
CurrentNumber = null;


        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            bw.Write(Flags);

StringUtil.Serialize(Hash,bw);
if ((Flags & 1) != 0)
BoolUtil.Serialize(CurrentNumber.Value,bw);

        }
		public override void DeserializeResponse(BinaryReader br)
		{
			Response = (Auth.TLSentCode)ObjectUtils.DeserializeObject(br);

		}
    }
}
