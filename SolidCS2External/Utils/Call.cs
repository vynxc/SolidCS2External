namespace SolidCS2External.Utils;

/// <summary>
///     Provides a mechanism to execute an action only once.
/// </summary>
public static class Call
{
    /// <summary>
    ///     Executes the given action only once based on the specified flag.
    /// </summary>
    /// <param name="flag">The flag that indicates whether the action has been called before.</param>
    /// <param name="action">The action to be executed.</param>
    public static void Once(OnceFlag flag, Action action)
    {
        if (flag.CheckIfCalledAndSet) action.Invoke();
    }
}

/// <summary>
///     Represents a flag that can be set only once.
/// </summary>
public class OnceFlag
{
    /// <summary>
    ///     Represents a constant value that indicates the state of not being called.
    /// </summary>
    private const int NotCalled = 0;

    /// <summary>Represents the value of the constant variable called.</summary>
    private const int Called = 1;

    /// <summary>
    ///     Represents the current state of the object.
    /// </summary>
    private int _state = NotCalled;

    /// <summary>
    ///     Gets a value indicating whether the CheckIfCalledAndSet property has been called and set.
    /// </summary>
    /// <remarks>
    ///     This property internally uses Interlocked.Exchange method to atomically set the state of _state field to Called,
    ///     and then checks if the previous state was set to NotCalled.
    /// </remarks>
    /// <returns>
    ///     "true" if the CheckIfCalledAndSet property has been called and set; otherwise, "false".
    /// </returns>
    /// /
    internal bool CheckIfCalledAndSet
    {
        get
        {
            var prev = Interlocked.Exchange(ref _state, Called);

            return prev == NotCalled;
        }
    }

    /// <summary>
    ///     Resets the state of the object.
    /// </summary>
    internal void Reset()
    {
        Interlocked.Exchange(ref _state, NotCalled);
    }
}