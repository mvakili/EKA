//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Logic.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class AdminUser
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public System.DateTime InsertDate { get; set; }
        public bool IsActive { get; set; }
        public string LastName { get; set; }
        public bool IsAdmin { get; set; }
    }
}
