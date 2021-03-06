﻿using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text.RegularExpressions;

namespace GoogleTestAdapter.Tests.Common
{
    [SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
    public static class TestResources
    {
#if DEBUG
        private const string BuildConfig = "Debug";
#else
        private const string BuildConfig = "Release";
#endif

        public const string SampleTestsSolutionDir = @"..\..\..\..\SampleTests\";
        public const string TestdataDir = @"..\..\..\Tests.Common\bin\" + BuildConfig + @"\Resources\TestData\";

        public const string Results0Batch = @"Tests\Returns0.bat";
        public const string Results1Batch = @"Tests\Returns1.bat";

        public const int NrOfSampleTests = 88;
        public const string SampleTests = SampleTestsSolutionDir + @"Debug\Tests_gta.exe";
        public const string SampleTestsRelease = SampleTestsSolutionDir + @"Release\Tests_gta.exe";

        public static readonly string LoadTests = Path.Combine(SampleTestsSolutionDir, @"Release\LoadTests_gta.exe");
        public static readonly string LongRunningTests = Path.Combine(SampleTestsSolutionDir, @"Release\LongRunningTests_gta.exe");

        public const string HardCrashingSampleTests = SampleTestsSolutionDir + @"Debug\CrashingTests_gta.exe";

        public const string X86Dir = TestdataDir + @"_x86\";
        public const string X86StaticallyLinkedTests = X86Dir + @"StaticallyLinkedGoogleTests\StaticallyLinkedGoogleTests.exe";
        public const string X86ExternallyLinkedTests = X86Dir + @"ExternallyLinkedGoogleTests\ExternallyLinkedGoogleTests.exe";
        public const string X86ExternallyLinkedTestsDll = X86Dir + @"ExternallyLinkedGoogleTests\ExternalGoogleTestLibrary.dll";
        public const string X86CrashingTests = X86Dir + @"CrashingGoogleTests\CrashingGoogleTests.exe";
        public const string X86TestsWithoutPdb = X86Dir + @"NoPdbFile\ConsoleApplication1Tests.exe";
        public const string PathExtensionTestsExe = X86Dir + @"PathExtension\exe\Tests.exe";
        public static readonly string PathExtensionTestsDllDir = Path.GetFullPath(X86Dir + @"PathExtension\lib");
        public const string AlwaysCrashingExe = X86Dir + @"Crash\CrashingExe.exe";
        public const string AlwaysFailingExe = X86Dir + @"Fail\FailingExe.exe";
        public const int NrOfPathExtensionTests = 72;

        public const string X64Dir = TestdataDir + @"_x64\";
        public const string X64StaticallyLinkedTests = X64Dir + @"StaticallyLinkedGoogleTests\StaticallyLinkedGoogleTests.exe";
        public const string X64ExternallyLinkedTests = X64Dir + @"ExternallyLinkedGoogleTests\ExternallyLinkedGoogleTests.exe";
        public const string X64CrashingTests = X64Dir + @"CrashingGoogleTests\CrashingGoogleTests.exe";

        public const string XmlFile1 = TestdataDir + @"SampleResult1.xml";
        public const string XmlFile2 = TestdataDir + @"SampleResult2.xml";
        public const string XmlFileBroken = TestdataDir + @"SampleResult1_Broken.xml";
        // ReSharper disable once InconsistentNaming
        public const string XmlFileBroken_InvalidStatusAttibute = TestdataDir + @"SampleResult1 _Broken_InvalidStatusAttribute.xml";

        public const string SolutionTestSettings = TestdataDir + @"RunSettingsServiceTests\Solution.gta.runsettings";
        public const string UserTestSettings = TestdataDir + @"RunSettingsServiceTests\User.runsettings";
        public const string UserTestSettingsWithoutRunSettingsNode = TestdataDir + @"RunSettingsServiceTests\User_WithoutRunSettingsNode.runsettings";
        public const string UserTestSettingsForGeneratedTests = TestdataDir + "User.runsettings";
        public const string UserTestSettingsForListingTests = TestdataDir + "ListTests.runsettings";
        public const string ProviderDeliveredTestSettings = TestdataDir + @"RunSettingsServiceTests\Provider_delivered.runsettings";

        public static string GetGoldenFileName(string typeName, string testCaseName, string fileExtension)
        {
            return typeName + "__" + testCaseName + fileExtension;
        }

        public static string GetVsTestConsolePath(TestMetadata.Versions version)
        {
            return @"C:\Program Files (x86)\" + $"Microsoft Visual Studio {version:d}.0" + @"\Common7\IDE\CommonExtensions\Microsoft\TestWindow\vstest.console.exe";
        }

        public static string NormalizePointerInfo(string text)
        {
            return Regex.Replace(text, "([0-9A-F]{8}){1,2} pointing to", "${MemoryLocation} pointing to");
        }

    }

}