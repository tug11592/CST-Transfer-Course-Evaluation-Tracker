﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CST_Transfer_UI_Project
{
    public class StudentTicket
    {
        public int TicketID { get; set; }
        public String Status { get; set; }
        public String DateCreated { get; set; }
        public String TransferCourse { get; set; }
        public String StudentFirst { get; set; }
        public String StudentLast { get; set; }

        public String TransferUniversity { get; set; }
        public String Department { get; set; }
    }
}