//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Raport_Online
{
    using System;
    using System.Collections.Generic;
    
    public partial class ASPEK
    {
        public ASPEK()
        {
            this.SUB_ASPEK = new HashSet<SUB_ASPEK>();
        }
    
        public int ID_ASPEK { get; set; }
        public string NAMA_ASPEK { get; set; }
        public string DIBUAT_OLEH { get; set; }
        public System.DateTime DIBUAT_PADA { get; set; }
        public string DIUBAH_OLEH { get; set; }
        public Nullable<System.DateTime> DIUBAH_PADA { get; set; }
        public bool STATUS_AKTIF { get; set; }
    
        public virtual ICollection<SUB_ASPEK> SUB_ASPEK { get; set; }
    }
}
