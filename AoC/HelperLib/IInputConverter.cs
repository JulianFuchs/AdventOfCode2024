namespace Day1_HistorianHysteria.CommonHelpers
{
    public interface IInputConverter<T>
    {
        public T ConvertInput(string[] input);
    }
}
