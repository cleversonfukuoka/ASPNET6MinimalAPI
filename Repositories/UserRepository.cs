using System;
using PRJ_ASPNET6_MinimalAPI;
using PRJ_ASPNET6_MinimalAPI.Models;

namespace PRJ_ASPNET6_MinimalAPI.Repositories
{
	public static class UserRepository
	{
		public static User Get(string username, string password)
		{			
			var users = new List<User>()
			{
				new User {Id =1, UserName = "batman", Password = "batman", Role="manager"},
				new User {Id=2, UserName = "robin", Password="robin", Role="employee"}
			};

			return users.Where(x => x.UserName.ToLower() == username.ToLower() &&  (x.Password == password)).First();					 
		}
	}
}
