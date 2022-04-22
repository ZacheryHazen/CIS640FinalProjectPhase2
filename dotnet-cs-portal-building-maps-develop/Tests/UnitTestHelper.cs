/*
* Licensed under the MIT License, see LICENSE file for details.
*/

using System;
using Xunit;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Ksu.Cs.Portal.Data;

namespace Ksu.Cs.Portal.Tests
{
    /// <summary>
    /// A class which contains helper functions for unit testing.
    /// </summary>
    public class UnitTestHelper
    {
        /// <summary>
        /// Creates and returns a PortalContext object that is set up for testing.
        /// </summary>
        /// <returns>
        /// A PortalContext object with the database set up to use a memory-based 
        /// database.
        /// </returns>
        public static PortalContext GetTestingPortalContext() 
        {
            // Adapted from https://docs.microsoft.com/en-us/ef/core/testing/testing-without-the-database#sqlite-in-memory
            SqliteConnection _connection;

            DbContextOptions<PortalContext> _contextOptions;
            
            // Create and open a connection. This creates the SQLite in-memory 
            // database, which will persist until the connection is closed at 
            // the end of the test.
            _connection = new SqliteConnection("Filename=:memory:");
            _connection.Open();

            // These options will be used by the context instances in this test 
            // suite, including the connection opened above.
            _contextOptions = new DbContextOptionsBuilder<PortalContext>()
                .UseSqlite(_connection)
                .Options;

            // Create the PortalContext and the Database
            PortalContext context = new PortalContext(_contextOptions);
            context.Database.EnsureCreated();

            return context;
        }
    }
}