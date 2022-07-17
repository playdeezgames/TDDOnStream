using EverCraftCs;
using Shouldly;
using Xunit;

namespace EverCraft.CsTests
{
    public class CharacterTests
    {
        [Fact]
        public void ShouldHaveAName()
        {
            const string Name = "Name";
            var subject = new Character
            {
                Name = Name
            };
            subject.Name.ShouldBe(Name);
        }
        [Theory]
        [InlineData(Alignment.Good)]
        [InlineData(Alignment.Neutral)]
        [InlineData(Alignment.Evil)]
        public void ShouldHaveAnAlignment(Alignment alignment)
        {
            var subject = new Character
            {
                Alignment = alignment
            };
            subject.Alignment.ShouldBe(alignment);
        }
    }
}