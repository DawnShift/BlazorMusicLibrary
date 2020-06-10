using Microsoft.AspNetCore.Components.Forms;

namespace BlazorCustomComponents
{
    public class CustomInputSelect<T> : InputSelect<T>
    {
        protected override bool TryParseValueFromString(string value, out T result, out string validationErrorMessage)
        {
            if (typeof(T) == typeof(int))
            {
                if (int.TryParse(value, out var resultInt))
                {
                    result = (T)(object)resultInt;
                    validationErrorMessage = null;
                    return true;
                }
                else
                {
                    result = default;
                    validationErrorMessage =
                        $"The Selected value {value} is not a valid number";
                    return false;
                }
            }
            else
                return base.TryParseValueFromString(value, out result, out validationErrorMessage);
        }
    }
}
