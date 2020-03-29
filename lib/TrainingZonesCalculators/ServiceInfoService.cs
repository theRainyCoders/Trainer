using System;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using TheRainyCoders.Trainer.Backend.Contract.ServiceInfo;

namespace TheRainyCoders.Trainer.Lib.TrainingZones.Calculators
{
    internal class ServiceInfoService : Backend.Contract.ServiceInfo.ServiceInfoService.ServiceInfoServiceBase
    {
        public override Task<ServiceInfoResponse> Info(ServiceInfoRequest request, ServerCallContext context)
        {
            var response = new ServiceInfoResponse
            {
                Version = "0.0"
            };

            return Task.FromResult(response);
        }
    }
}
