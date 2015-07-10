using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Machine.Specifications;

namespace fizzbuzz.tests
{
    [Subject(typeof(FizzBuzz))]
    public class When_Playing_To_Fifty_Five
    {
        Establish context = () => { Subject = new FizzBuzz(); };

        Because of = () => Actual = Subject.Play(1,55);

        It should_have_fifty_five_responses = () => { Actual.Count().Should().Be(55); };

        It should_fizz_on_numbers_divisible_by_threes = () =>
        {
            Actual[2].Should().Be("Fizz");
            Actual[5].Should().Be("Fizz");
            Actual[8].Should().Be("Fizz");
        };

        It should_fizz_on_numbers_containing_three = () =>
        {
            Actual[12].Should().Be("Fizz");
            Actual[22].Should().Be("Fizz");
        };

        It should_buzz_on_numbers_divisible_by_fives = () =>
        {
            Actual[9].Should().Be("Buzz");
        };

        It should_buzz_on_numbers_containing_five = () =>
        {
            Actual[51].Should().Be("Buzz");
        };

        It should_fizzbuzz_on_numbers_divisible_by_three_and_five = () =>
        {
            Actual[14].Should().Be("FizzBuzz");
        };

        It should_fizzbuzz_on_number_containing_three_and_five = () =>
        {
            Actual[52].Should().Be("FizzBuzz");
        };
        
        static FizzBuzz Subject;
        static List<string> Actual;
    } 
}
