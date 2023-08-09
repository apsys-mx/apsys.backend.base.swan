using $ext_safeprojectname$.repositories;
using $ext_safeprojectname$.services;

namespace $safeprojectname$
{
    [ScenarioName("InitializeApplication")]
    public class SC002_InitializeApplication : IScenario
    {
        private readonly IUnitOfWork uoW;

        public SC002_InitializeApplication(IUnitOfWork uoW)
        {
            this.uoW = uoW;
        }

        public async void SeedData()
        {
            var command = new ApplicationInitializer.Command();
            var handler = new ApplicationInitializer.Handler(this.uoW);
            await handler.Handle(command, CancellationToken.None);
        }
    }
}
