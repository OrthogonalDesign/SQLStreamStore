﻿ // ReSharper disable once CheckNamespace
namespace SqlStreamStore
{
    using System.Threading.Tasks;
    using SqlStreamStore.InMemory;
    using Xunit.Abstractions;

    public class InMemoryAcceptanceTests : AcceptanceTests
    {
        public InMemoryAcceptanceTests(ITestOutputHelper testOutputHelper)
            : base(testOutputHelper)
        { }

        protected override Task<IStreamStoreFixture> CreateFixture() 
            => Task.FromResult<IStreamStoreFixture>(new InMemoryStreamStoreFixture());
    }
}