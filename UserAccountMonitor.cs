using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;

namespace WinSecSentinel
{
    public class UserAccountMonitor
    {
        public List<string> CheckUserAccounts()
        {
            var alerts = new List<string>();
            using (var context = new PrincipalContext(ContextType.Machine))
            {
                using (var searcher = new PrincipalSearcher(new UserPrincipal(context)))
                {
                    foreach (var result in searcher.FindAll())
                    {
                        if (result is UserPrincipal user)
                        {
                            if (user.IsAccountLockedOut())
                            {
                                alerts.Add($"[WARNING] User account is locked: {user.SamAccountName}");
                            }
                            if (user.Enabled == true && user.LastLogon == null)
                            {
                                alerts.Add($"[INFO] New user account detected: {user.SamAccountName}");
                            }
                        }
                    }
                }

                using (var groupSearcher = new PrincipalSearcher(new GroupPrincipal(context, "Administrators")))
                {
                    if (groupSearcher.FindOne() is GroupPrincipal group)
                    {
                        foreach (var member in group.GetMembers())
                        {
                            alerts.Add($"[ADMIN] User '{member.SamAccountName}' is a member of the Administrators group.");
                        }
                    }
                }
            }
            return alerts;
        }
    }
}