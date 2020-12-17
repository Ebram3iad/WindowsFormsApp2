using System.ComponentModel.DataAnnotations;

namespace WindowsFormsApp2
{
    public class Categories
    {
        public int CategoryID { get; set; }
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }
    }
}
