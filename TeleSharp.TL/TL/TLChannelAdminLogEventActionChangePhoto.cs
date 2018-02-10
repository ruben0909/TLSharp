using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	[TLObject(-1204857405)]
    public class TLChannelAdminLogEventActionChangePhoto : TLAbsChannelAdminLogEventAction
    {
        public override int Constructor
        {
            get
            {
                return -1204857405;
            }
        }

             public TLAbsChatPhoto PrevPhoto {get;set;}
     public TLAbsChatPhoto NewPhoto {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            PrevPhoto = (TLAbsChatPhoto)ObjectUtils.DeserializeObject(br);
NewPhoto = (TLAbsChatPhoto)ObjectUtils.DeserializeObject(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            ObjectUtils.SerializeObject(PrevPhoto,bw);
ObjectUtils.SerializeObject(NewPhoto,bw);

        }
    }
}
