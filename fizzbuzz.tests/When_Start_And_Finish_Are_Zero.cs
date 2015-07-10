using System.Collections.Generic;
using FluentAssertions;
using Machine.Specifications;

namespace fizzbuzz.tests
{
    [Subject(typeof(FizzBuzz))]
    public class When_Start_And_Finish_Are_Zero
    {
        Establish context = () => Subject = new FizzBuzz();

        Because of = () => Actual = Subject.Play(0,0);

        It should_return_a_blank_message = () => { Actual.Should().BeEmpty(); };
        
        static FizzBuzz Subject;
        static List<string> Actual;
    }
}
