﻿using System.Collections.Generic;
using Elasticsearch.Net.Utf8Json;

namespace Nest
{
	[JsonFormatter(typeof(DictionaryResponseFormatter<GetSnapshotLifecycleResponse, string, SnapshotLifecyclePolicyMetadata>))]
	public class GetSnapshotLifecycleResponse : DictionaryResponseBase<string, SnapshotLifecyclePolicyMetadata>
	{
		public IReadOnlyDictionary<string, SnapshotLifecyclePolicyMetadata> Policies => Self.BackingDictionary;
	}
}
