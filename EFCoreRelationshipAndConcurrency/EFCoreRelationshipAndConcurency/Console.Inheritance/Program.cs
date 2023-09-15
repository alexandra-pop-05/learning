using SecondDomain;
using SecondDomain.HEntities;


#region TPH Inheritance


//using (var context = new TPH_EFCoreDbContext())
//{
//    var systemRole = new SystemRole { Description = "Description 1", IsAdmin = false, SystemRoleName = "Regular User" };
//    var teamRole = new TeamRole { Description = "Description 2", IsBackend = true, TeamRoleName = "Junior Developer" };

//    context.Roles.Add(systemRole);
//    context.Roles.Add(teamRole);
//    context.SaveChanges();

//    var roles = context.Roles.ToList();
//    foreach (var role in roles)
//    {
//        Console.WriteLine($"Role: {role.Description}, Type: {role.Type}");
//        if (role is SystemRole currentSystemRole)
//        {
//            Console.WriteLine($"  IsAdmin: {currentSystemRole.IsAdmin}");
//        }
//        else if (role is TeamRole currentTeamRole)
//        {
//            Console.WriteLine($"  IsAdmin:  {currentTeamRole.IsBackend}");
//        }
//    }
//}

#endregion


#region TPT Inheritance



using (var context = new TPT_EFCoreDbContext())
{
    var systemRole = new SystemRole { Description = "Description 1", IsAdmin = false, SystemRoleName = "Regular User" };
    var teamRole = new TeamRole { Description = "Description 2", IsBackend = true, TeamRoleName = "Junior Developer" };

    context.Roles.Add(systemRole);
    context.Roles.Add(teamRole);
    context.SaveChanges();

    var roles = context.Roles.ToList();
    foreach (var role in roles)
    {
        if (role is SystemRole currentSystemRole)
        {
            Console.WriteLine($"  IsAdmin: {currentSystemRole.IsAdmin}");
        }
        else if (role is TeamRole currentTeamRole)
        {
            Console.WriteLine($"  IsAdmin:  {currentTeamRole.IsBackend}");
        }
    }
}

#endregion