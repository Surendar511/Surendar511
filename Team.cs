using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinWebRESTService
{
    public class Customer
    {
        public string CustomerName { get; set; }
        public string Address { get; set; }
    }
    public class Team
    {
        public string col1 { get; set; }
        public string col2 { get; set; }
        public string col3 { get; set; }
        public string col4 { get; set; }
        public string col5 { get; set; }
    }
    public class Team6
    {
        public string col1 { get; set; }
        public string col2 { get; set; }
        public string col3 { get; set; }
        public string col4 { get; set; }
        public string col5 { get; set; }
        public string col6 { get; set; }
    }

    public class BOMlist
    {
        public string branchcd {get; set;}
        public string asterisk { get; set; }
        public string lvl {get; set;}
        public string icode {get; set;}
        public string pcode {get; set;}
        public string vcode {get; set;}
        public string lotsize { get; set; }
        public string mqty { get; set; }

        public string ibqty {get; set;}
        public string ibcode {get; set;}
        public string irate {get; set;}
        public string val {get; set;}
      
        public string iname {get; set;}
        public string pcpartno {get; set;}
        public string ibname {get; set;}
        public string cpartno {get; set;}
        public string unit {get; set;}
        public string jr {get; set;}

        public string gross_wt { get; set; }
        public string net_wt { get; set; }
        public string assembly_iden { get; set; }

        public string total_net_wt { get; set; }
    }

    public class Team_Dr
    {
        public string col1 { get; set; }
        public string col2 { get; set; }
        public string col3 { get; set; }
        public string col4 { get; set; }
        public string col5 { get; set; }
        public byte[] img { get; set; }
    }
    public class Team10
    {
        public string col1 { get; set; }
        public string col2 { get; set; }
        public string col3 { get; set; }
        public string col4 { get; set; }
        public string col5 { get; set; }
        public string col6 { get; set; }
        public string col7 { get; set; }
        public string col8 { get; set; }
        public string col9 { get; set; }
        public string col10 { get; set; }

    }
}