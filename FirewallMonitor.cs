using System;
using System.Collections.Generic;
using System.Linq;
using NetFwTypeLib;

namespace WinSecSentinel
{
    public class FirewallMonitor
    {
        public List<string> GetFirewallRules()
        {
            var rules = new List<string>();
            try
            {
                var firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
                rules.AddRange(firewallPolicy.Rules.Cast<INetFwRule>().Select(rule => $"Rule: {rule.Name}, Action: {rule.Action}, Enabled: {rule.Enabled}"));
            }
            catch (Exception ex)
            {
                rules.Add($"Error getting firewall rules: {ex.Message}");
            }

            return rules;
        }
    }
}