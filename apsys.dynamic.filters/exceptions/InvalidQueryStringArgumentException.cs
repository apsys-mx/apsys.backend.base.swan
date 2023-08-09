namespace $safeprojectname$.exceptions
{
    public class InvalidQueryStringArgumentException : ApplicationException
    {
        public InvalidQueryStringArgumentException(string argName)
            : base($"Parameter [{argName}] has an invalid value.")
        {
        }
    }
}
