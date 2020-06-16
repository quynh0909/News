using System;
using System.Collections.Generic;
using System.Text;

namespace News.Data.Entities
{
    public class ChuyenMuc
    {
        public int CateID { get; set; }
        public string CateName { get; set; }
        public int CateTT { get; set; }
        public CateHide CateHide { get; set; }
       
    }
}
