using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace BlazorBBS.Data
{
	public class ThreadResponseContext : IdentityDbContext
	{
		public ThreadResponseContext(DbContextOptions<ThreadResponseContext> option) : base(option)
		{
		}
		public DbSet<ThreadResponseData> ThreadResponse { get; set; }
	}

	public class ThreadResponseData
	{
		public int Id { get; set; }

		public int ResponseId { get; set; }

		public string Email { get; set; }
		public string Name { get; set; }
		public string Text { get; set; }
		public DateTime CreateDateTime { get; set; }
		public DateTime LastUpdate { get; set; }

		public int ParentThreadId { get; set; }

		[NotMapped]
		public ThreadData ParentThread { get; set; }
	}
}
