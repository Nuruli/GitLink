﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BitBucketIntegration.cs" company="CatenaLogic">
//   Copyright (c) 2014 - 2016 CatenaLogic. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace GitLink.Tests.IntegrationTests
{
    using NUnit.Framework;

    [TestFixture, Explicit]
    public class BitBucketIntegration : IntegrationTestBase
    {
        public const string Url = "https://bitbucket.org/CatenaLogic/GitLinkTestRepro";
        public const string Directory = @"C:\Source\GitLinkTestRepro_BitBucket";

        [Test]
        public void CorrectlyUpdatesPdbFiles()
        {
            const string directory = Directory;
            const string configurationName = "Release";

            var result = RunGitLink(directory, Url, "master", configurationName);

            Assert.AreEqual(0, result);

            VerifyUpdatedPdbs(directory, configurationName);
        }
    }
}