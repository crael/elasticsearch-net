using Elastic.Xunit.XunitPlumbing;
using Nest;
using System.ComponentModel;

namespace Examples.Transform.Apis
{
	public class DeleteTransformPage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		[Description("transform/apis/delete-transform.asciidoc:52")]
		public void Line52()
		{
			// tag::70c736ecb3746dbe839af0e468712805[]
			var response0 = new SearchResponse<object>();
			// end::70c736ecb3746dbe839af0e468712805[]

			response0.MatchesExample(@"DELETE _transform/ecommerce_transform");
		}
	}
}