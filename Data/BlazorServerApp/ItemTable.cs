﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace BlazorServerAppDB.Data.BlazorServerApp
{
    public partial class ItemTable
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public string ItemName { get; set; }
        public string Category { get; set; }
        public string UserName { get; set; }
        public int CategoryId { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}