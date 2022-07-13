using PurchaseRequester.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseRequester.Domain.Requests
{
    public class Request
    {
        private int id;
        private DateTime createdTime = DateTime.Now;
        private RequestStatus status = RequestStatus.NEW;

        public int Id { get => id; set => id = value; }
        public string PartNo { get; set; }
        public string ModelNo { get; set; }
        public string UsedOn { get; set; }
        public string Description { get; set; }
        public double Quantity { get; set; }
        public string LeadTime { get; set; }
        public User Issuer { get; set; }
        public DateTime CreatedDate { get => createdTime; set => createdTime = value; }
        public DateTime RequestedTime;

        public RequestCatagory Catagory { get; set; }
        public RequestStatus Status { get => status; set => status = value; }

        public bool isEmergency { get; set; }
    }
}
