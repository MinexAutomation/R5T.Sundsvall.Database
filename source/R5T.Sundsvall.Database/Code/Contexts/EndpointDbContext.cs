﻿using System;

using Microsoft.EntityFrameworkCore;


namespace R5T.Sundsvall.Database
{
    public class EndpointDbContext : DbContext
    {
        public DbSet<Entities.Endpoint> Endpoints { get; set; }
        public DbSet<Entities.EndpointType> EndpointTypes { get; set; }

        public DbSet<Entities.EndpointToCatchmentMapping> EndpointToCatchmentMappings { get; set; }


        public EndpointDbContext(DbContextOptions<EndpointDbContext> options)
            : base(options)
        {
        }
    }
}
