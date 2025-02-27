﻿using Tigernet.Hosting.Actions;
using Tigernet.Hosting.Attributes.HttpMethods;
using Tigernet.Hosting.Attributes.Resters;

namespace Tigernet.Samples.RestApi.Resters
{
    [ApiRester]
    public class HomeRester : ResterBase
    {
        [Getter]
        public object Index()
        {
            return Ok(new
            {
                Message = "Hello World!"
            });
        }

        [Getter("/show")]
        public object ShowMessage()
        {
            return Ok(new
            {
                Message = "Check for dublication of routes"
            });
        }
    }
}
