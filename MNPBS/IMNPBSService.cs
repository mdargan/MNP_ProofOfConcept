using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MNPBS
{
    // Example of service contract
    [ServiceContract(Namespace = "http://localhost/schema/v1")]
    public interface IMNPBSService
    {
        [OperationContract]
        CancelPortOutResponse cancelPortOut(CancelPortOutRequest message);
    }

    [MessageContract(
        WrapperName = "CancelPortOutRequest",
        IsWrapped = true,
        WrapperNamespace = "http://localhost/schema/v1")]
    public class CancelPortOutRequest
    {
        [MessageHeader(
            Name = "sdpServiceHeaders",
            Namespace = "http://localhost/schema/v1",
     MustUnderstand = true)]
        public SDPServiceHeaders sdpServiceHeaders { get; set; }

        [MessageBodyMember(
           Name = "requestId",
           Namespace = "http://localhost/schema/v1")]
        public string requestId { get; set; }
    }

    [MessageContract(
       WrapperName = "CancelPortOutResponse",
       IsWrapped = true,
       WrapperNamespace = "http://localhost/schema/v1")]
    public class CancelPortOutResponse
    {
        [MessageHeader(
            Name = "sdpServiceHeaders",
            Namespace = "http://localhost/schema/v1",
     MustUnderstand = true)]
        public SDPServiceHeaders sdpServiceHeaders { get; set; }

        [MessageBodyMember(
           Name = "cancelPortOutResponse",
           Namespace = "http://localhost/schema/v1")]
        public string responseId { get; set; }
    }

    [DataContract]
    public class SDPServiceHeaders
    {
        [DataMember]
        string applicationIdentity { get; set; }

        [DataMember]
        string systemIdentity { get; set; }

        // Other header attributes going here
    }

    [DataContract]
    public class CancelPortOutFault
    {

    }
}
