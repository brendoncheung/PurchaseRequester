using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseRequester.Domain.Requests
{
    public class Request
    {
        public int Id { get; set; }
        public string PartNo { get; set; }
        public string ModelNo { get; set; }
        public string UsedOn { get; set; }
        public string Comments { get; set; }
        public string LeadTime { get; set; }
        public string CreatedDate = DateTime.Now.ToString();
        public string RequestedTime;
        public Catagory catagory { get; set; }
        public RequestStatus Status = RequestStatus.PENDING;

        public override bool Equals(object obj)
        {
            return obj is Request request &&
                   Id == request.Id &&
                   PartNo == request.PartNo &&
                   ModelNo == request.ModelNo &&
                   UsedOn == request.UsedOn &&
                   Comments == request.Comments &&
                   LeadTime == request.LeadTime &&
                   CreatedDate == request.CreatedDate &&
                   RequestedTime == request.RequestedTime &&
                   catagory == request.catagory &&
                   Status == request.Status;
        }
    }

    public enum RequestStatus
    {
        WORKING,
        PENDING,
        COMPLETED,
    }

    public enum Catagory
    {
        TOOLING,
        MISC,
        PASSTHOUGH,
    }
}
