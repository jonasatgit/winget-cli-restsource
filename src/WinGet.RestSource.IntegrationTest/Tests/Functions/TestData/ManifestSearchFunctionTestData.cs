// -----------------------------------------------------------------------
// <copyright file="ManifestSearchFunctionTestData.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. Licensed under the MIT License.
// </copyright>
// -----------------------------------------------------------------------

namespace Microsoft.WinGet.RestSource.IntegrationTest.Tests.Functions.TestData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.WinGet.RestSource.IntegrationTest.Common;
    using Microsoft.WinGet.RestSource.IntegrationTest.Common.Helpers;

    /// <summary>
    /// Manifest search function test data.
    /// </summary>
    public class ManifestSearchFunctionTestData : BaseTestData
    {
        private const string PowerToysPackageIdentifier = "Microsoft.PowerToys";
        private const string AzureCliPackageIdentifier = "Microsoft.AzureCLI";
        private const string VSCodePackageIdentifier = "Microsoft.VisualStudioCode";
        private const string CodeLitePackageIdentifier = "CodeLite.CodeLite";

        /// <summary>
        /// Initializes a new instance of the <see cref="ManifestSearchFunctionTestData"/> class.
        /// </summary>
        public ManifestSearchFunctionTestData()
        {
            this.Data = new List<object[]>()
            {
                new object[]
                {
                    new ManifestSearchTestHelper()
                    {
                        StorageCleanup = new StorageCleanup()
                        {
                            EndPointRequests = new EndPointRequest[]
                            {
                                new EndPointRequest()
                                {
                                    RelativeUrlPath = $"packageManifests/{PowerToysPackageIdentifier}",
                                },
                                new EndPointRequest()
                                {
                                    RelativeUrlPath = $"packageManifests/{AzureCliPackageIdentifier}",
                                },
                                new EndPointRequest()
                                {
                                    RelativeUrlPath = $"packageManifests/{VSCodePackageIdentifier}",
                                },
                                new EndPointRequest()
                                {
                                    RelativeUrlPath = $"packageManifests/{CodeLitePackageIdentifier}",
                                },
                            },
                        },
                        StorageSetup = new StorageSetup()
                        {
                            EndPointRequests = new EndPointRequest[]
                            {
                                new EndPointRequest()
                                {
                                    RelativeUrlPath = $"packageManifests",
                                    JsonFileName = "powertoys.json",
                                    TestCollateralType = TestCollateral.TestCollateralType.Manifests,
                                },
                                new EndPointRequest()
                                {
                                    RelativeUrlPath = $"packageManifests",
                                    JsonFileName = "azure-cli.json",
                                    TestCollateralType = TestCollateral.TestCollateralType.Manifests,
                                },
                                new EndPointRequest()
                                {
                                    RelativeUrlPath = $"packageManifests",
                                    JsonFileName = "code-lite.json",
                                    TestCollateralType = TestCollateral.TestCollateralType.Manifests,
                                },
                                new EndPointRequest()
                                {
                                    RelativeUrlPath = $"packageManifests",
                                    JsonFileName = "vs-code.json",
                                    TestCollateralType = TestCollateral.TestCollateralType.Manifests,
                                },
                            },
                        },
                        EndPointRequest = new EndPointRequest()
                        {
                            RelativeUrlPath = "manifestSearch",
                            JsonFileName = "match-type-substring.json",
                            TestCollateralType = TestCollateral.TestCollateralType.RequestFiles,
                        },
                        SearchResponses = new SearchResponseTestHelper[]
                        {
                            new SearchResponseTestHelper()
                            {
                                PackageIdentifier = "CodeLite.CodeLite",
                                Publisher = "CodeLite",
                                ExpectedVersions = new string[] { "14.0.0" },
                            },
                            new SearchResponseTestHelper()
                            {
                                PackageIdentifier = "Microsoft.VisualStudioCode",
                                Publisher = "Microsoft Corporation",
                                ExpectedVersions = new string[] { "1.65.2", "1.65.3" },
                            },
                        },
                        MaximumAllowedResponseTime = 3,
                    },
                },
            };
        }
    }
}
