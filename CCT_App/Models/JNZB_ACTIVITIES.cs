//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CCT_App.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class JNZB_ACTIVITIES
    {
        public int ENTRY_ID { get; set; }
        public string SESS_CDE { get; set; }
        public string ACT_CDE { get; set; }
        public string ID_NUM { get; set; }
        public string PART_CDE { get; set; }
        public bool MEMBERSHIP_STS { get; set; }
        public bool TRACK_MTG_ATTEND { get; set; }
        public System.DateTime BEGIN_DTE { get; set; }
        public System.DateTime END_DTE { get; set; }
        public string COMMENT_TXT { get; set; }
        public bool INCL_PROFILE_RPT { get; set; }
        public string USER_NAME { get; set; }
        public string USER_JOB { get; set; }
        public Nullable<System.DateTime> JOB_TIME { get; set; }
    }
}
