using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EdjCase.JsonRpc.Router.Sample.RpcRoutes
{
	public class RpcMath
	{
		public int Add(int a, int b)
		{
			return a + b;
		}

		public async Task<int> AddAsync(int? a = null, int? b = null)
		{
			return await Task.Run(() => a ?? 0 + b ?? 0);
		}


		public int AddArray(int[] a)
		{
			return a[0] + a[1];
		}

		public int AddList(List<int> a)
		{
			return a[0] + a[1];
		}

	}
}
