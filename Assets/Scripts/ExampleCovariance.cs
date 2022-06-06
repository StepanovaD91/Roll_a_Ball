namespace Maze
{
    public sealed class ExampleCovariance
    {
        public void Main()
        {
            Bonus bonus = new GoodBonus();

            ITestCovariance<Bonus> testInvariance = new TestCovariance<Bonus>(); // Инвариантность: позволяет использовать только заданный тип
            ITestCovariance<Bonus> testCovariance = new TestCovariance<GoodBonus>(); //Ковариантность: позволяет использовать более конкретный тип, чем заданный изначально <out T>
            ITestContravariance<GoodBonus> testContravariance = new TestContravariance<Bonus>(); // Контравариантность: позволяет использовать более универсальный тип, чем заданный изначально <in T>
        }
    }
        
    public class Bonus
    {

    }
    public class GoodBonus : Bonus
    {

    }
    public interface ITestCovariance<out T>
    {
        T Test(int t);
    }
    public class TestCovariance<T> : ITestCovariance<T>
    {
        public T Test(int t)
        {
            return default;
        }
    }
    public interface ITestContravariance<in T>
    {
        void Test(T t);
    }
    public class TestContravariance<T> : ITestContravariance<T>
    {
        public void Test(T t)
        {

        }
    }
}
