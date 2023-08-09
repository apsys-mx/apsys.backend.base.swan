using apsys.ndbunit.netcore;

namespace $safeprojectname$
{
    /// <summary>
    /// Create sandbox
    /// </summary>
    [ScenarioName("CreateSandBox")]
    public class SC001_CreateSandBox : IScenario
    {
        private readonly INDbUnit _nDbUnit;

        public SC001_CreateSandBox(INDbUnit nDbUnit)
        {
            this._nDbUnit = nDbUnit;
        }

        public void SeedData()
        {
            this._nDbUnit.ClearDatabase();
        }
    }
}
