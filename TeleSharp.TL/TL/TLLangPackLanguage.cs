using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	[TLObject(292985073)]
    public class TLLangPackLanguage : TLObject
    {
        public override int Constructor
        {
            get
            {
                return 292985073;
            }
        }

             public string Name {get;set;}
     public string NativeName {get;set;}
     public string LangCode {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Name = StringUtil.Deserialize(br);
NativeName = StringUtil.Deserialize(br);
LangCode = StringUtil.Deserialize(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            StringUtil.Serialize(Name,bw);
StringUtil.Serialize(NativeName,bw);
StringUtil.Serialize(LangCode,bw);

        }
    }
}
