using System;
using System.Collections.Generic;
using System.Text;

namespace News.Data.Entities
{
    public class LoaiTin
    {
        public int LTID { get; set; }
        public string LTName { get; set; }
        public int LTThuTu { get; set; }
        public LTHide LTHide { get; set; }
        public int CateID { get; set; }

        public List<TinTuc> TinTucs { get; set; }

        
    }
    
}
