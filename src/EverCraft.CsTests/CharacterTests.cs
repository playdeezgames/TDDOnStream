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
    }
}