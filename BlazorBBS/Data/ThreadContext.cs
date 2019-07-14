using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace BlazorBBS.Data
{
	public class ThreadContext : IdentityDbContext
	{
		public ThreadContext(DbContextOptions<ThreadContext> option) : base(option)
		{
		}

		public DbSet<ThreadData> Thread { get; set; }
	}

	public class ThreadData
	{
		public int Id { get; set; }

		public string Email { get; set; }
		public string Name { get; set; }
		public string Title { get; set; }
		public string Text { get; set; }
		public DateTime CreateDateTime { get; set; }
		public DateTime LastUpdate { get; set; }

		[NotMapped]
		public List<ThreadResponseData> Response { get; set; } = new List<ThreadResponseData>();

	}	
}
