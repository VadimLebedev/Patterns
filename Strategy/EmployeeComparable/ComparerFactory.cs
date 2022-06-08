namespace Strategy.EmployeeComparable
{
    internal class ComparerFactory
    {
        public static IComparer<T> Create<T>(Comparison<T> comparison)
        {
            return new DelegateComparer<T>(comparison);
        }

        private class DelegateComparer<T> : IComparer<T>
        {
            private readonly Comparison<T> comparison;

            public DelegateComparer(Comparison<T> comparison)
            {
                this.comparison = comparison;
            }

            public int Compare(T? x, T? y)
            {
                return comparison(x, y);
            }
        }
    }
}
