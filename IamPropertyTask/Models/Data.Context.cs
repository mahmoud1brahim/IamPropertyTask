

namespace IamPropertyTask.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Data : DbContext
    {
        public Data()
            : base("name=Data")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<bool> IsPalindrom(string word)
        {
            var wordParameter = word != null ?
                new ObjectParameter("Word", word) :
                new ObjectParameter("Word", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<bool>("IsPalindrom", wordParameter);
        }
    }
}
