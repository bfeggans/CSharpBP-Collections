namespace Acme.Common
{
    /// <summary>
    /// Provides a success flag and message 
    /// useful as a method return type.
    /// </summary>
<<<<<<< HEAD
    public class OperationResult<T>
=======
    public class OperationResult
>>>>>>> 1914c218c7bb3528d80a2209924444d08d8cea63
    {
        public OperationResult()
        {
        }

<<<<<<< HEAD
        public OperationResult(T success, string message) : this()
=======
        public OperationResult(bool success, string message) : this()
>>>>>>> 1914c218c7bb3528d80a2209924444d08d8cea63
        {
            this.Success = success;
            this.Message = message;
        }

<<<<<<< HEAD
        public T Success { get; set; }
=======
        public bool Success { get; set; }
>>>>>>> 1914c218c7bb3528d80a2209924444d08d8cea63
        public string Message { get; set; }
    }

}
