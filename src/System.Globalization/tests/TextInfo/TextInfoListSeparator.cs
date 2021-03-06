// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Globalization;
using Xunit;

namespace System.Globalization.Tests
{
    public class TextInfoListSeparator
    {
        private int _MINI_STRING_LENGTH = 1;
        private int _MAX_STRING_LENGTH = 20;
        private readonly RandomDataGenerator _generator = new RandomDataGenerator();

        // PosTest1: Verify ListSeparator of en-US CultureInfo's TextInfo is  not empty
        [Fact]
        public void VerifyEnUSListSeperator()
        {
            CultureInfo ci = new CultureInfo("en-US");
            TextInfo textInfoUS = ci.TextInfo;
            Assert.NotEqual(String.Empty, textInfoUS.ListSeparator);
        }

        // PosTest2: Verify setting  ListSeparator
        [Fact]
        public void SetListSeperator()
        {
            CultureInfo ci = new CultureInfo("en-US");
            TextInfo textInfoUS = ci.TextInfo;
            string strListSeparator = _generator.GetString(-55, false, _MINI_STRING_LENGTH, _MAX_STRING_LENGTH);
            textInfoUS.ListSeparator = strListSeparator;
            Assert.Equal(strListSeparator, textInfoUS.ListSeparator);
        }

        // NegTest1: Setting ListSeparator as a null reference
        [Fact]
        public void SetNullReference()
        {
            TextInfo textInfoUS = new CultureInfo("en-US").TextInfo;
            string str = null;

            Assert.Throws<ArgumentNullException>(() =>
            {
                textInfoUS.ListSeparator = str;
            });
        }
    }
}

