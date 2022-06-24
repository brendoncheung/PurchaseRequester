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
        public string Description { get; set; }
        public double Quantity { get; set; }
        public string LeadTime { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime RequestedTime;
        public RequestCatagory catagory = RequestCatagory.MISC;
        public RequestStatus Status = RequestStatus.PENDING;
        public bool isEmergency { get; set; }
    }
}
