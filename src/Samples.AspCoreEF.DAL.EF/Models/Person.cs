using System;

namespace Samples.AspCoreEF.DAL.EF.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
