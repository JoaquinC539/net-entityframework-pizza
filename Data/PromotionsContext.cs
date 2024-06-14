using System;
using System.Collections.Generic;
using ContosoPizza.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoPizza.Data;

public partial class PromotionsContext : DbContext
{
    public PromotionsContext()
    {
    }

    public PromotionsContext(DbContextOptions<PromotionsContext> options)
        : base(options)
    {
    }

    public  DbSet<Coupon> Coupons { get; set; }

    

    
}
