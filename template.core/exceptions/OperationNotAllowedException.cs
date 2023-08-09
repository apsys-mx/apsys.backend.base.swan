namespace $safeprojectname$.exceptions
{
    public class OperationNotAllowedException : Exception
    {
        public OperationNotAllowedException() { }
        public OperationNotAllowedException(string message) : base(message) { }
    }
}
