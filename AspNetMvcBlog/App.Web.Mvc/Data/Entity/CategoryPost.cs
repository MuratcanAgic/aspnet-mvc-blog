using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace App.Web.Mvc.Data.Entity
{
    public class CategoryPost
    {   
        public int PostId { get; set; }     
        public Post Post { get; set; }        
        public int CategoryId { get; set; }     
        public Category Category { get; set; }
               
    }
}
