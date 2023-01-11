using Xunit;
using WebApplication1.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using DotNet.Testcontainers.Builders;
using DotNet.Testcontainers.Containers;
using System.ComponentModel;

namespace WebApplication1.Controllers.Tests
{
    public class ValuesControllerTests
    {
        [Fact()]
        public async Task GetTest()
        {
            //// Start the service 1 container
            //ITestcontainersContainer container1 = new TestcontainersBuilder<TestcontainersContainer>()
            //    .WithImage("service2:dev")
            //    .WithPortBinding(80, true)
            //    .WithExposedPort(80)
            //    .WithPortBinding(5002, 80)
            //    .Build();
           

            //await container1.StartAsync();

            //var _service1Container = new TestcontainersBuilder<TestcontainersContainer>()
            //        .WithImage("service2:dev")
            //        .WithPortBinding(80, true)
            //        .WithExposedPort(80)
            //        .WithPortBinding(5002, 80)
            //        .Build();
            //await _service1Container.StartAsync();

            //// Start the service 2 container
            //TestcontainersContainer _service2Container = new TestcontainersBuilder<TestcontainersContainer>()
            //        .WithImage("service3:dev")
            //        .WithPortBinding(80, true)
            //        .WithPortBinding(80)
            //        .WithExposedPort(5003)
            //        .Build();
            //_service2Container.StartAsync().GetAwaiter().GetResult();

            var webApplicationFactory = new WebApplicationFactory<Program>();
            var client = webApplicationFactory.CreateClient();
            var result = await client.GetAsync("http://localhost/api/Values/");

            Assert.True(result.IsSuccessStatusCode);
        }
    }
}