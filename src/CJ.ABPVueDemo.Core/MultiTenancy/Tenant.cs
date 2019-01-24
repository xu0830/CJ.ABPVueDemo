using Abp.MultiTenancy;
using CJ.ABPVueDemo.Authorization.Users;

namespace CJ.ABPVueDemo.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
