using System;
using System.ComponentModel.DataAnnotations;

namespace MIP_Lab5
{
   


public class Product
{
    public int Id { get; set; }

    [Required]
    [StringLength(30)]
    public string Name { get; set; }

    [StringLength(500)]
    public string Description { get; set; }

    public DateTime EntryDate { get; set; }

    public DateTime ExpiryDate { get; set; }

    public int Quantity { get; set; }
}

}
