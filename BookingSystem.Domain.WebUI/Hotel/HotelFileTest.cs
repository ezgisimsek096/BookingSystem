using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BookingSystem.Domain.WebUI.Hotel
{
    public class HotelFileTest
    {
        public int HotelId { get; set; }

        public string HotelName { get; set; }
        public HttpPostedFileBase HotelImage { get; set; }
    }
}
