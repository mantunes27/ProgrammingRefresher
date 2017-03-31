using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using ProgrammingRefresher;

namespace UnitTest
{
    [TestFixture]
    public class UnitTests
    {
        [Test]
        public void ShouldAddTwoNumbers()
        {
            var sut = new ElementaryExercises();
            var result = sut.addition(1, 1);

            Assert.That(result, Is.EqualTo(2));
        }
    }
}

