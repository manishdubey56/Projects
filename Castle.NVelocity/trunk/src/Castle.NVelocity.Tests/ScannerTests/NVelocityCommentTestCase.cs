// Copyright 2007 Jonathon Rossi - http://www.jonorossi.com/
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Castle.NVelocity.Tests.ScannerTests
{
    using NUnit.Framework;

    [TestFixture]
    public class NVelocityCommentTestCase : ScannerTestBase
    {
        [Test]
        public void NVelocitySingleLineStartComment()
        {
            scanner.SetSource(
                "##");

            AssertMatchToken(TokenType.NVSingleLineComment, "##");

            AssertEOF();
        }

        [Test]
        public void NVelocitySingleLineComment()
        {
            scanner.SetSource(
                "## comment");

            AssertMatchToken(TokenType.NVSingleLineComment, "## comment");

            AssertEOF();
        }

        [Test]
        public void NVelocitySingleLineCommentWithPrecedingXmlText()
        {
            scanner.SetSource(
                "before ## comment");

            AssertMatchToken(TokenType.XmlText, "before ");
            AssertMatchToken(TokenType.NVSingleLineComment, "## comment");

            AssertEOF();
        }

        [Test]
        public void NVelocitySingleLineCommentWithPrecedingAndFollowingXmlText()
        {
            scanner.SetSource(
                "before ## comment\n" +
                "after");

            AssertMatchToken(TokenType.XmlText, "before ");
            AssertMatchToken(TokenType.NVSingleLineComment, "## comment\n");
            AssertMatchToken(TokenType.XmlText, "after");

            AssertEOF();
        }

        [Test]
        public void NVelocitySingleLineCommentWithFollowingEmptyLine()
        {
            scanner.SetSource(
                "before ## comment\n" +
                "\n" +
                "after");

            AssertMatchToken(TokenType.XmlText, "before ");
            AssertMatchToken(TokenType.NVSingleLineComment, "## comment\n");
            AssertMatchToken(TokenType.XmlText, "\nafter");

            AssertEOF();
        }

        [Test]
        public void NVelocityStartOfMultiLineComment()
        {
            scanner.SetSource(
                "#*");

            try
            {
                AssertMatchToken(TokenType.NVSingleLineComment);
                Assert.Fail();
            }
            catch (ScannerError) { }

            AssertEOF();
        }

        [Test]
        public void NVelocityMultiLineComment()
        {
            scanner.SetSource(
                "#**#");

            AssertMatchToken(TokenType.NVSingleLineComment, "#**#");

            AssertEOF();
        }

        [Test]
        public void NVelocityMultiLineCommentSingleLineText()
        {
            scanner.SetSource(
                "#* this is the comment *#");

            AssertMatchToken(TokenType.NVSingleLineComment, "#* this is the comment *#");

            AssertEOF();
        }

        [Test]
        public void NVelocityMultiLineCommentMultiLineText()
        {
            scanner.SetSource(
                "#* this is\n" +
                "the comment *#");

            AssertMatchToken(TokenType.NVSingleLineComment, "#* this is\nthe comment *#");

            AssertEOF();
        }

        [Test]
        public void NVelocityMultiLineCommentWithSurroundingXmlText()
        {
            scanner.SetSource(
                "this is xml #* this is\n" +
                "the comment *# and this is back to xml");

            AssertMatchToken(TokenType.XmlText, "this is xml ");
            AssertMatchToken(TokenType.NVSingleLineComment, "#* this is\nthe comment *#");
            AssertMatchToken(TokenType.XmlText, " and this is back to xml");

            AssertEOF();
        }

        [Test]
        public void NVelocityMultiLineCommentWithTouchingSurroundingXmlText()
        {
            scanner.SetSource(
                "before text#*comment*#after text");

            AssertMatchToken(TokenType.XmlText, "before text");
            AssertMatchToken(TokenType.NVSingleLineComment, "#*comment*#");
            AssertMatchToken(TokenType.XmlText, "after text");

            AssertEOF();
        }
    }
}