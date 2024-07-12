namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class client
    {
        public client()
        {
            this.Invoices = new HashSet<Invoice>();
            this.shoppings = new HashSet<shopping>();
        }
    
        public int client_id { get; set; }
        public string name { get; set; }
        public int code { get; set; }
    
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<shopping> shoppings { get; set; }
    }
}
