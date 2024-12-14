namespace HelperLib
{
    public interface IInputConverter<T>
    {
        public T ConvertInput(string[] input);
    }
}
