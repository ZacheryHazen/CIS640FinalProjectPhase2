/*
* Licensed under the MIT License, see LICENSE file for details.
*/

using System;
using System.Threading.Tasks;
using Xunit;
using Moq;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Abstractions;
using Ksu.Cs.Portal.Areas.Maps.Pages;
using Ksu.Cs.Portal.Areas.Maps.Models;
using Ksu.Cs.Portal.Data;
using Ksu.Cs.Portal.Areas.Maps.Services;
using Ksu.Cs.Portal.Controllers;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace Ksu.Cs.Portal.Tests
{
    /// <summary>
    /// Unit tests for pages relating to the building maps area of the CS Portal.
    /// </summary>
    public class MapsPagesUnitTests
    {
        /// <summary>
        /// Whether the unit tests can find the IndexModel.
        /// </summary>
        [Fact]
        public void IndexModel_CanFindIndexModel()
        {
            // Arrange
            IndexModel model = new IndexModel(UnitTestHelper.GetTestingPortalContext(), 
                new NullLogger<IndexModel>());

            // Assert
            Assert.IsType<IndexModel>(model);
        }

        /// <summary>
        /// Whether OnGet retrieves the correct set of building data.
        /// </summary>
        [Fact]
        public async Task IndexModel_OnGetRetrievesCorrectBuildingData() {
            // Arrange
            using var context = UnitTestHelper.GetTestingPortalContext();

            // Data to add - combines with pre-filled data in the PortalContext, 
            // which is always created when setting up a new database, even 
            // the in-memory one.
            Building Engg = new Building
            {
                Id = 54,
                BuildingName = "Engineering Hall",
                BuildingAbrev = "ENGG"
            };
            Building Anderson = new Building
            {
                Id = 87,
                BuildingName = "Anderson Hall",
                BuildingAbrev = "A"
            };

            context.AddRange(Engg, Anderson);
            context.SaveChanges();

            IndexModel model = new IndexModel(context, new NullLogger<IndexModel>());

            // Act
            await model.OnGetAsync();

            // Assert
            Assert.True(model.BuildingList != null);
            Assert.Equal<int>(5, model.BuildingList.Count);
            Assert.Equal(Engg.BuildingName, model.BuildingList[3].BuildingName);
            Assert.NotEqual(Anderson.BuildingName, model.BuildingList[3].BuildingName);
            Assert.Equal(Anderson.BuildingName, model.BuildingList[4].BuildingName);
            Assert.NotEqual(Engg.BuildingName, model.BuildingList[4].BuildingName);
        }

        /// <summary>
        /// Whether the unit tests can find the Admin.
        /// </summary>
        [Fact]
        public void Admin_CanFindAdmin()
        {
            // Arrange
            Admin model = new Admin(UnitTestHelper.GetTestingPortalContext(), 
                new NullLogger<Admin>(), new ProcessRequestQueue(10));

            // Assert
            Assert.IsType<Admin>(model);
        }

        /// <summary>
        /// Whether the ProcessQueue correctly enqueues a building pdf file
        /// <summary>
        [Fact]
        public async void Admin_ProcessQueueEnqueuesCorrectly() {
            // Arrange
            using var context = UnitTestHelper.GetTestingPortalContext();
            
            // Setup mock file using memory stream
            var content = "Hello World: This is a fake file";
            var fileName = "test.pdf";
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(content);
            writer.Flush();
            stream.Position = 0;

            // Initialize a queue
            IProcessRequestQueue queue = new ProcessRequestQueue(10);

            // Create a file to input into the queue
            IFormFile formFile = new FormFile(stream, 0, stream.Length, null, fileName);

            // Enqueue the file
            var filePath = Path.GetTempFileName();
            using var sr = System.IO.File.Create(filePath);
            await formFile.CopyToAsync(sr);

            await queue.EnqueueAsync(new ProcessRequest() 
            {
                FilePath = filePath
            });

            // Assert
            Assert.NotNull(queue);
        }
    }
}
