﻿using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace Segment.Model
{
    using Traits = System.Collections.Generic.IDictionary<string, object>;
    public class Identify : BaseAction
    {
        [JsonProperty(PropertyName = "traits")]
		public Traits Traits { get; set; }

        internal Identify(string userId,
		                  Traits traits, 
						  Options options)
	
			: base("identify", userId, options)
        {
            this.Traits = traits ?? new Dictionary<string, object>();
        }
    }
}
