// -----------------------------------------------------------------------
// <copyright file="ManifestSearchFunctionsTests.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. Licensed under the MIT License.
// </copyright>
// -----------------------------------------------------------------------

namespace Microsoft.WinGet.RestSource.IntegrationTest.Tests.Functions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.WinGet.RestSource.IntegrationTest.Common.Fixtures;
    using Xunit;

    /// <summary>
    /// Manifest search functions tests.
    /// </summary>
    [Collection("IntegrationTestCollection")]
    public class ManifestSearchFunctionsTests
    {
        private IntegrationTestFixture fixture;

        /// <summary>
        /// Initializes a new instance of the <see cref="ManifestSearchFunctionsTests"/> class.
        /// </summary>
        /// <param name="fixture">An object <see cref="IntegrationTestFixture"/>.</param>
        public ManifestSearchFunctionsTests(IntegrationTestFixture fixture)
        {
            this.fixture = fixture;
        }
    }
}
