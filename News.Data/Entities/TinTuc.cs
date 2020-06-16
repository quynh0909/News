using System;
using System.Collections.Generic;
using System.Text;

namespace News.Data.Entities
{
    public class TinTuc
    {
        public int TinID { get; set; }
        public string TieuDe { get; set; }
        public string TomTat { get; set; }
        public string NoiDung { get; set; }
        public string UrlImg { get; set; }
        public DateTime NgayDang { get; set; }
        public int SoLanXem { get; set; }
        public string KeyWord { get; set; }
        public TinNoiBat TinNoiBat { get; set; }
        public int? LTID { get; set; }
        public LoaiTin LoaiTin { get; set; }
    }
}
