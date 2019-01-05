using Volo.Abp;

namespace YF.Life
{
    public abstract class LifeApplicationTestBase : AbpIntegratedTest<LifeApplicationTestModule>
    {
        protected override void SetAbpApplicationCreationOptions(AbpApplicationCreationOptions options)
        {
            options.UseAutofac();
        }
    }
}
