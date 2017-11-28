using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Szkolenie_zad1
{
    public class MatematykaTest
    {
        [Fact]
        public void Add_return_sum_of_given_values()
        {
            //przygotowanie - arrange
            //var math = new Matematyka(); - może być tak albo tak jak poniżej
            Matematyka math = new Matematyka();

            //test - act
            var result = math.Add(10, 20);

            //sprawdzenie wyników - assert
            Assert.Equal(30, result);
        }

        [Fact]
        public void Add_return_sum_of_given_values_where_one_is_even()
        {
            //przygotowanie - arrange
            //var math = new Matematyka(); - może być tak albo tak jak poniżej
            Matematyka math = new Matematyka();

            //test - act
            var result = math.Add(10, -20);

            //sprawdzenie wyników - assert
            Assert.Equal(-10, result);
        }

        [Fact]
        public void Subtract_return_difference_of_given_values_where_two_are_even()
        {
            //przygotowanie - arrange
            //var math = new Matematyka(); - może być tak albo tak jak poniżej
            Matematyka math = new Matematyka();

            //test - act
            var result = math.Subtract(-10, -20);

            //sprawdzenie wyników - assert
            Assert.Equal(10, result);
        }

        [Fact]
        public void Subtract_return_difference_of_given_values_where_one_is_fraction()
        {
            //przygotowanie - arrange
            //var math = new Matematyka(); - może być tak albo tak jak poniżej
            Matematyka math = new Matematyka();

            //test - act
            var result = math.Subtract(10, 0.666);

            //sprawdzenie wyników - assert
            Assert.Equal(9.334, result);
        }

        [Fact]
        public void Multiply_return_multiplication_of_two_given_values_one_is_zero()
        {
            //przygotowanie - arrange
            //var math = new Matematyka(); - może być tak albo tak jak poniżej
            Matematyka math = new Matematyka();

            //test - act
            var result = math.Multiply(10, 0);

            //sprawdzenie wyników - assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Multiply_return_multiplication_of_two_given_values_one_is_fraction()
        {
            //przygotowanie - arrange
            //var math = new Matematyka(); - może być tak albo tak jak poniżej
            Matematyka math = new Matematyka();

            //test - act
            var result = math.Multiply(10, 0.5);

            //sprawdzenie wyników - assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Divide_return_division_of_two_given_values_one_is_fraction()
        {
            //przygotowanie - arrange
            //var math = new Matematyka(); - może być tak albo tak jak poniżej
            Matematyka math = new Matematyka();

            //test - act
            var result = math.Divide(10, 0.5);

            //sprawdzenie wyników - assert
            Assert.Equal(20, result);
        }

        [Fact]
        public void Divide_return_division_of_two_given_values_divider_is_zero()
        {
            //przygotowanie - arrange
            //var math = new Matematyka(); - może być tak albo tak jak poniżej
            Matematyka math = new Matematyka();

            //test - act
            var result = math.Divide(10, 0);

            //sprawdzenie wyników - assert
            Assert.Equal(Double.PositiveInfinity, result);
        }

    }
}
