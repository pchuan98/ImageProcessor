using ImageProcessor.Common.Models;
using NUnit.Framework;

namespace Test.ImageProcessor.Common.Models
{
    [TestFixture]
    public class ImageTests
    {
        public const string Path1 = @"F:\Company\src\Simscop.Visual\test\1.jpg";

        public const string Path2 = @"F:\Company\src\Simscop.Visual\test\d16.jpg";

        public const string Path3 = @"F:\Company\src\Simscop.Visual\test\d48.png";

        public const string Path4 = @"F:\Company\src\Simscop.Visual\test\hela .png";


        public ImageTests()
        {

        }

        [Test]
        public void Dispose_StateUnderTest_ExpectedBehavior()
        {
            var image = new Image();
            image.Dispose();

            Assert.Fail();
        }
    }
}
