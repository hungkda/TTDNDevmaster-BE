﻿namespace NetCoreMVCLab04.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public float SalePrice { get; set; }
        public byte Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Image {  get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
    }
}
