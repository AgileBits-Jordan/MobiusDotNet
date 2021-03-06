﻿using Newtonsoft.Json;

namespace MobiusDotNet.Resources
{
    /// <summary>
    ///     Base class for responses.
    /// </summary>
    public abstract class Response
    {
        /// <inheritdoc />
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}