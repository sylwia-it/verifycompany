using DocumentGenerator.Lib.Helpers;
using NUnit.Framework;

namespace DocumentGenerator.Lib.Test
{
    public class NumToWordsPlnConvTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ZeroTest()
        {
            Assert.AreEqual("zero z這tych 00/100", NumberToWordsConverter.ConvertNumberToAmountPln("0"));
        }

        [Test]
        public void OneDigitNumTest()
        {
            Assert.AreEqual("jeden z這ty 00/100", NumberToWordsConverter.ConvertNumberToAmountPln("1"));
            Assert.AreEqual("pi耩 z這tych 00/100", NumberToWordsConverter.ConvertNumberToAmountPln("5"));
            Assert.AreEqual("dziewi耩 z這tych 00/100", NumberToWordsConverter.ConvertNumberToAmountPln("9"));
            Assert.AreEqual("dziewi耩 z這tych 00/100", NumberToWordsConverter.ConvertNumberToAmountPln("9,00"));
            Assert.AreEqual("trzy z這te 00/100", NumberToWordsConverter.ConvertNumberToAmountPln("3"));
            Assert.AreEqual("trzy z這te 00/100", NumberToWordsConverter.ConvertNumberToAmountPln("3.00"));
        }

        [Test]
        public void TeenstNumTest()
        {
            Assert.AreEqual("dziesi耩 z這tych 00/100", NumberToWordsConverter.ConvertNumberToAmountPln("10"));
            Assert.AreEqual("jedena�cie z這tych 89/100", NumberToWordsConverter.ConvertNumberToAmountPln("11,89"));
            Assert.AreEqual("dwana�cie z這tych 87/100", NumberToWordsConverter.ConvertNumberToAmountPln("12.87"));
            Assert.AreEqual("trzyna�cie z這tych 76/100", NumberToWordsConverter.ConvertNumberToAmountPln("13.76"));
            Assert.AreEqual("dziewi皻na�cie z這tych 00/100", NumberToWordsConverter.ConvertNumberToAmountPln("19"));
           
        }
    
        [Test]
        public void TwoDigitNumTest()
        {
            Assert.AreEqual("dwadzie�cia jeden z這tych 00/100", NumberToWordsConverter.ConvertNumberToAmountPln("21"));
            Assert.AreEqual("trzydzie�ci dwa z這te 00/100", NumberToWordsConverter.ConvertNumberToAmountPln("32"));
            Assert.AreEqual("czterdzie�ci cztery z這te 00/100", NumberToWordsConverter.ConvertNumberToAmountPln("44"));
            Assert.AreEqual("pi耩dziesi靖 pi耩 z這tych 00/100", NumberToWordsConverter.ConvertNumberToAmountPln("55"));
            Assert.AreEqual("sze�熛ziesi靖 sze�� z這tych 00/100", NumberToWordsConverter.ConvertNumberToAmountPln("66"));
            Assert.AreEqual("sze�熛ziesi靖 z這tych 00/100", NumberToWordsConverter.ConvertNumberToAmountPln("60"));
            Assert.AreEqual("siedemdziesi靖 trzy z這te 00/100", NumberToWordsConverter.ConvertNumberToAmountPln("73"));
            Assert.AreEqual("osiemdziesi靖 siedem z這tych 00/100", NumberToWordsConverter.ConvertNumberToAmountPln("87"));
            Assert.AreEqual("dziewi耩dziesi靖 osiem z這tych 00/100", NumberToWordsConverter.ConvertNumberToAmountPln("98"));
            Assert.AreEqual("dwadzie�cia dwa z這te 34/100", NumberToWordsConverter.ConvertNumberToAmountPln("22.34"));
        }

        [Test]
        public void ThreeNumTest()
        {
            Assert.AreEqual("sto dwadzie�cia dziewi耩 z這tych 00/100", NumberToWordsConverter.ConvertNumberToAmountPln("129"));
            Assert.AreEqual("trzysta pi皻na�cie z這tych 00/100", NumberToWordsConverter.ConvertNumberToAmountPln("315"));
            Assert.AreEqual("osiemset pi耩dziesi靖 cztery z這te 00/100", NumberToWordsConverter.ConvertNumberToAmountPln("854"));
            Assert.AreEqual("dziewi耩set dziewi耩dziesi靖 dziewi耩 z這tych 00/100", NumberToWordsConverter.ConvertNumberToAmountPln("999"));
        }

        [Test]
        public void FourDigitNumTest()
        {
            Assert.AreEqual("jeden tysi鉍 dwie�cie trzydzie�ci trzy z這te 00/100", NumberToWordsConverter.ConvertNumberToAmountPln("1233"));
            Assert.AreEqual("dwa tysi鉍e trzysta trzy z這te 00/100", NumberToWordsConverter.ConvertNumberToAmountPln("2303"));
            Assert.AreEqual("sze�� tysi璚y trzyna�cie z這tych 00/100", NumberToWordsConverter.ConvertNumberToAmountPln("6013"));
            Assert.AreEqual("pi耩 tysi璚y dwie�cie dwadzie�cia osiem z這tych 00/100", NumberToWordsConverter.ConvertNumberToAmountPln("5228"));
            Assert.AreEqual("trzy tysi鉍e sto z這tych 00/100", NumberToWordsConverter.ConvertNumberToAmountPln("3100"));
        }

        [Test]
        public void FiveDigitNumTest()
        {
            Assert.AreEqual("jedena�cie tysi璚y dwie�cie czterdzie�ci cztery z這te 00/100", NumberToWordsConverter.ConvertNumberToAmountPln("11244"));
            Assert.AreEqual("dwadzie�cia dwa tysi鉍e czterysta jeden z這tych 00/100", NumberToWordsConverter.ConvertNumberToAmountPln("22401"));
            Assert.AreEqual("pi耩dziesi靖 sze�� tysi璚y czterna�cie z這tych 00/100", NumberToWordsConverter.ConvertNumberToAmountPln("56014"));
            Assert.AreEqual("trzydzie�ci jeden tysi璚y z這tych 00/100", NumberToWordsConverter.ConvertNumberToAmountPln("31000"));
            Assert.AreEqual("dwadzie�cia tysi璚y trzy z這te 00/100", NumberToWordsConverter.ConvertNumberToAmountPln("20003"));
            Assert.AreEqual("dziesi耩 tysi璚y czterysta pi耩dziesi靖 sze�� z這tych 00/100", NumberToWordsConverter.ConvertNumberToAmountPln("10456"));

        }

        [Test]
        public void SiXDigitNumTest()
        {
            Assert.AreEqual("sto dwadzie�cia jeden tysi璚y dwie�cie czterdzie�ci pi耩 z這tych 00/100", NumberToWordsConverter.ConvertNumberToAmountPln("121245"));
            Assert.AreEqual("trzysta dwa tysi鉍e trzy z這te 00/100", NumberToWordsConverter.ConvertNumberToAmountPln("302003"));
            Assert.AreEqual("pi耩set tysi璚y jedena�cie z這tych 00/100", NumberToWordsConverter.ConvertNumberToAmountPln("500011"));
            Assert.AreEqual("dziewi耩set jedena�cie tysi璚y trzyna�cie z這tych 00/100", NumberToWordsConverter.ConvertNumberToAmountPln("911013"));
            Assert.AreEqual("sto tysi璚y z這tych 00/100", NumberToWordsConverter.ConvertNumberToAmountPln("100000"));
            Assert.AreEqual("sto dwa tysi鉍e dwie�cie dwa z這te 00/100", NumberToWordsConverter.ConvertNumberToAmountPln("102202"));

        }

    }
}