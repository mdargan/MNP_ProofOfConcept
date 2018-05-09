using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MNPBS
{
    [ServiceBehavior(AddressFilterMode = AddressFilterMode.Any)]
    public class MNPBSService : IMNPBSService
    {

        public CancelPortOutResponse cancelPortOut(CancelPortOutRequest message)
        {
            CancelPortOutResponse response = new CancelPortOutResponse();
            response.responseId = System.DateTime.UtcNow.Millisecond.ToString();

            //Return same headers back
            response.sdpServiceHeaders = message.sdpServiceHeaders;
            return response;
        }
    }
}
