using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWarm
{
    public class AllUsers
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public byte[] ProfilePhoto { get; set; }
        public Image ProfilePhotoObject { get; set; }
    }
}
