﻿using SparkDotnet8.Application.Database;
using SparkDotnet8.Application.Models;
using SparkDotnet8.Application.Startup; 
using Microsoft.EntityFrameworkCore;

namespace SparkDotnet8.Application.Services.Auth;

public class RolesService
{
    private readonly IDbContextFactory<DatabaseContext> _factory;

    public RolesService(IDbContextFactory<DatabaseContext> factory)
    {
        _factory = factory;
    }

    public async Task<List<Role>> FindUserRolesAsync(int userId)
    {
        using var context = _factory.CreateDbContext();
        var roles = await context.Roles.Where(role => role.UserRoles.Any(x => x.UserId == userId)).ToListAsync();
        return roles;
    }

    public async Task<bool> IsUserInRole(int userId, string roleName)
    {
        using var context = _factory.CreateDbContext();
        var userRolesQuery = from role in context.Roles
                             where role.Name == roleName
                             from user in role.UserRoles
                             where user.UserId == userId
                             select role;
        var userRole = await userRolesQuery.FirstOrDefaultAsync();
        return userRole != null;
    }

    public async Task<List<User>> FindUsersInRoleAsync(string roleName)
    {
        using var context = _factory.CreateDbContext();
        var roleUserIdsQuery = from role in context.Roles
                               where role.Name == roleName
                               from user in role.UserRoles
                               select user.UserId;
        return await context.Users.Where(user => roleUserIdsQuery.Contains(user.Id))
            .ToListAsync();
    }
}
