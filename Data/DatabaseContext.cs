using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;

namespace C1_1.Data
{

public class DatabaseContext : DbContext{

    public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
            {

            }
            public DbSet<C1_1.Models.Formulario> formularios {get;set;}
}



}


