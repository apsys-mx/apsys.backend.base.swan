namespace $safeprojectname$.exceptions
{
    public class InvalidFieldNameException : ApplicationException
    {
        public InvalidFieldNameException(string argName)
            : base($"Field [{argName}] is not part of entity.")
        {
        }
    }
}
