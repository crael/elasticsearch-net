using Elastic.Xunit.XunitPlumbing;
using Nest;
using System.ComponentModel;

namespace Examples.QueryDsl
{
	public class WildcardQueryPage : ExampleBase
	{
		[U]
		[Description("query-dsl/wildcard-query.asciidoc:21")]
		public void Line21()
		{
			// tag::d31062ff8c015387889fed4ad86fd914[]
			var searchResponse = client.Search<object>(s => s
				.AllIndices()
				.Query(q => q
					.Wildcard(w => w
						.Field("user")
						.Value("ki*y")
						.Boost(1)
						.Rewrite(MultiTermQueryRewrite.ConstantScore)
					)
				)
			);
			// end::d31062ff8c015387889fed4ad86fd914[]

			searchResponse.MatchesExample(@"GET /_search
			{
			    ""query"": {
			        ""wildcard"": {
			            ""user"": {
			                ""value"": ""ki*y"",
			                ""boost"": 1.0,
			                ""rewrite"": ""constant_score""
			            }
			        }
			    }
			}");
		}
	}
}
