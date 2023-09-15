using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Mvc.Filters;
using Serilog;

// Setting ComVisible to false makes the types in this assembly not visible to COM
// components.  If you need to access a type in this assembly from COM, set the ComVisible
// attribute to true on that type.

[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM.

[assembly: Guid("ef088585-1419-483e-ad35-c4abcb98c8da")]

public class GlobalExceptionFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        // Log the exception using Serilog
        Log.Error(context.Exception, "An exception occurred");

        // You can also perform additional actions, such as returning a custom error response
        // context.Result = new ObjectResult("An error occurred") { StatusCode = 500 };
    }
}
