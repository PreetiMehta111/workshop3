using System;

public class NullOperations
{
    public void PerformNullChecks()
    {
        string username = null;

        // Using Ternary Operator
        Console.WriteLine(username == null ? "Username is not available" : username);

        // Using Null-Coalescing Operator
        Console.WriteLine(username ?? "Username is not available");

        // Using Null-Coalescing Assignment Operator
        username ??= "DefaultUser";
        Console.WriteLine("Updated Username: " + username);
    }
}