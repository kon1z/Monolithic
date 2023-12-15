using System.Runtime.Serialization;

namespace Monolithic;

/// <summary>
/// Base exception type for those are thrown by  system for  specific exceptions.
/// </summary>
public class AppException : Exception
{
    public AppException()
    {

    }

    public AppException(string? message)
        : base(message)
    {

    }

    public AppException(string? message, Exception? innerException)
        : base(message, innerException)
    {

    }

    public AppException(SerializationInfo serializationInfo, StreamingContext context)
        : base(serializationInfo, context)
    {

    }
}
