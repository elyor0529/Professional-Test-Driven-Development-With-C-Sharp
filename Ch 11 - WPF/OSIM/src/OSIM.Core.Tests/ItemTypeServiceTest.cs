// <copyright file="ItemTypeServiceTest.cs">Copyright ©  2016</copyright>
using System;
using System.Collections.Generic;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using NUnit.Framework;
using OSIM.Core.Entities;
using OSIM.Core.Services;

namespace OSIM.Core.Services.Tests
{
    /// <summary>This class contains parameterized unit tests for ItemTypeService</summary>
    [PexClass(typeof(ItemTypeService))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestFixture]
    public partial class ItemTypeServiceTest
    {
        /// <summary>Test stub for GetItemTypes()</summary>
        [PexMethod]
        public IList<ItemType> GetItemTypesTest([PexAssumeUnderTest]ItemTypeService target)
        {
            IList<ItemType> result = target.GetItemTypes();
            return result;
            // TODO: add assertions to method ItemTypeServiceTest.GetItemTypesTest(ItemTypeService)
        }
    }
}
