//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KGA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Attachment
    {
        public int FileID { get; set; }
        public Nullable<int> ProblemID { get; set; }
        public string UserName { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public byte[] Data { get; set; }
    
        public virtual ProblemsData ProblemsData { get; set; }
    }
}