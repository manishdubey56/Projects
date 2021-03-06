// Copyright 2004-2006 Castle Project - http://www.castleproject.org/
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

using Castle.Components.Validator.Contrib.Validators;
using NUnit.Framework;

namespace Castle.ActiveRecord.Validation.Tests
{
    [TestFixture]
    public class UrlValidatorTestCase
    {
        [Test]
        public void ValidationPassesForValidUrls()
        {
            UrlValidator validator = new UrlValidator();

            Assert.IsTrue(validator.IsValid(this, "http://www.castleproject.org"));
            Assert.IsTrue(validator.IsValid(this, "http://www.bbc.co.uk"));
            Assert.IsTrue(validator.IsValid(this, "ftp://my.ftp.site"));
            Assert.IsTrue(validator.IsValid(this, "http://www.tickets.com/file.extension?id=something"));
        }

        [Test]
        public void ValidationFailsForInvalidUrls()
        {
            UrlValidator validator = new UrlValidator();

            Assert.IsFalse(validator.IsValid(this, "http://www"));
            Assert.IsFalse(validator.IsValid(this, ".www.bbc.co.uk"));
            Assert.IsFalse(validator.IsValid(this, "ftp:///my.ftp.site"));
        }
    }
}