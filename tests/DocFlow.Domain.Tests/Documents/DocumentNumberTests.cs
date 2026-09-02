using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocFlow.Domain.Documents;
using FluentAssertions;

namespace DocFlow.Domain.Tests.Documents
{
    public class DocumentNumberTests
    {
        [Fact]
        public void Create_WhenValueHasOuterSpaces_TrimsValue()
        {
            var number = DocumentNumber.Create("    DOC-001    ");
            number.Value.Should().Be("DOC-001");
        }

        [Fact]
        public void Create_WhenValueIsEmpty_ThrowsArgumentException()
        {
            var action = () => DocumentNumber.Create(" ");
            action.Should().Throw<ArgumentException>().WithMessage("DocumentNumber is empty");
        }

        [Fact]
        public void Create_WhenValueIsLess_ThrowsArgumentException()
        {
            var action = () => DocumentNumber.Create("DO");
            action.Should().Throw<ArgumentException>().WithMessage("DocumentNumber's length must be between 2 and 30 characters");
        }

        [Fact]
        public void Create_WhenValueIsGreater_ThrowsArgumentException()
        {
            var action = () => DocumentNumber.Create("DOC-123456789101112131415161718120");
            action.Should().Throw<ArgumentException>().WithMessage("DocumentNumber's length must be between 2 and 30 characters");
        }

        [Fact]
        public void Create_WhenNumbersHaveEqualValues_TheyAreEqual()
        {
            var first = DocumentNumber.Create(" DOC-001");
            var second = DocumentNumber.Create("DOC-001 ");
            first.Should().Be(second);
        }
    }
}
