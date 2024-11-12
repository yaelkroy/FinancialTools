```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialTools
{
    public static class LanguageUtils
    {
        public static bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Runs an operation and ignores any Exceptions that occur.
        /// Returns true or falls depending on whether catch was
        /// triggered
        /// </summary>
        /// <param name="operation">lambda that performs an operation that might throw</param>
        /// <returns></returns>
        public static bool IgnoreErrors(Action operation)
        {
            if (operation == null)
                return false;
            try
            {
                operation.Invoke();
            }
            catch
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Runs an function that returns a value and ignores any Exceptions that occur.
        /// Returns true or falls depending on whether catch was
        /// triggered
        /// </summary>
        /// <param name="operation">parameterless lamda that returns a value of T</param>
        /// <param name="defaultValue">Default value returned if operation fails</param>
        public static T IgnoreErrors<T>(Func<T> operation, T defaultValue = default)
        {
            if (operation == null)
                return defaultValue;

            T result;
            try
            {
                result = operation.Invoke();
            }
            catch
            {
                result = defaultValue;
            }

            return result;
        }
    }
}
```