using System;
using Xunit;
using Task2;
namespace UnitTestFileDetails
{
    public class Tests
    {
        #region Negative Scenarios
        //Null Values 
        [Fact]
        public void GetVersionOrSize_NullValues_NoResult()
        {
            //Act
            string result = Task2.VersionSize.GetVersionOrSize(null, null);

            //Asserts
            Assert.Equal("No Version Or Size Found", result);
        }

        //Blank Values
        [Fact]
        public void GetVersionOrSize_BlankValues_NoResult()
        {
            //Act
            string result = Task2.VersionSize.GetVersionOrSize("", "");

            //Asserts
            Assert.Equal("No Version Or Size Found", result);
        }

        //Random Values
        [Fact]
        public void GetVersionOrSize_RandomValues_NoResult()
        {
            //Act
            string result = Task2.VersionSize.GetVersionOrSize("test", "test2");

            //Asserts
            Assert.Equal("No Version Or Size Found", result);
        }
        #endregion

        #region Version Scenarios
        //-v passed as first argument
        [Fact]
        public void GetVersionOrSize_v_Passed_ReturnsVersion()
        {
            //Act
            string result = Task2.VersionSize.GetVersionOrSize("-v", "");

            //Asserts
            Assert.NotNull(result);
        }

        //--v passed as first argument
        [Fact]
        public void GetVersionOrSize__v_Passed_ReturnsVersion()
        {
            //Act
            string result = Task2.VersionSize.GetVersionOrSize("--v", "");

            //Asserts
            Assert.NotNull(result);
        }

        // /v passed as first argument
        [Fact]
        public void GetVersionOrSize___v_Passed_ReturnsVersion()
        {
            //Act
            string result = Task2.VersionSize.GetVersionOrSize("/v", "");

            //Asserts
            Assert.NotNull(result);
        }

        //--version passed as first argument
        [Fact]
        public void GetVersionOrSize_version_Passed_ReturnsVersion()
        {
            //Act
            string result = Task2.VersionSize.GetVersionOrSize("--version", "");

            //Asserts
            Assert.NotNull(result);
        }

        #endregion

        #region Size Scenarios
        //-s passed as first argument
        [Fact]
        public void GetVersionOrSize_s_Passed_v()
        {
            //Act
            string result = Task2.VersionSize.GetVersionOrSize("-s", "");

            //Asserts
            Assert.NotNull(result);
        }

        //--s passed as first argument
        [Fact]
        public void GetVersionOrSize__s_Passed_ReturnsSize()
        {
            //Act
            string result = Task2.VersionSize.GetVersionOrSize("--s", "");

            //Asserts
            Assert.NotNull(result);
        }

        // /s passed as first argument
        [Fact]
        public void GetVersionOrSize___s_Passed_ReturnsSize()
        {
            //Act
            string result = Task2.VersionSize.GetVersionOrSize("/s", "");

            //Asserts
            Assert.NotNull(result);
        }

        //--size passed as first argument
        [Fact]
        public void GetVersionOrSize_version_Passed_ReturnsSize()
        {
            //Act
            string result = Task2.VersionSize.GetVersionOrSize("--size", "");

            //Asserts
            Assert.NotNull(result);
        }
        #endregion
    }
}
