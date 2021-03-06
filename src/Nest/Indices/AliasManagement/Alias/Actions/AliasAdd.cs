﻿using System;
using System.Runtime.Serialization;
using Elasticsearch.Net.Utf8Json;

namespace Nest
{
	[InterfaceDataContract]
	public interface IAliasAddAction : IAliasAction
	{
		[DataMember(Name ="add")]
		AliasAddOperation Add { get; set; }
	}

	public class AliasAddAction : IAliasAddAction
	{
		public AliasAddOperation Add { get; set; }
	}

	public class AliasAddDescriptor : DescriptorBase<AliasAddDescriptor, IAliasAddAction>, IAliasAddAction
	{
		public AliasAddDescriptor() => Self.Add = new AliasAddOperation();

		AliasAddOperation IAliasAddAction.Add { get; set; }

		/// <inheritdoc cref="AliasAddOperation.Index"/>
		public AliasAddDescriptor Index(string index)
		{
			Self.Add.Index = index;
			return this;
		}

		/// <inheritdoc cref="AliasAddOperation.Index"/>
		public AliasAddDescriptor Index(Type index)
		{
			Self.Add.Index = index;
			return this;
		}

		/// <inheritdoc cref="AliasAddOperation.Index"/>
		public AliasAddDescriptor Index<T>() where T : class
		{
			Self.Add.Index = typeof(T);
			return this;
		}

		/// <inheritdoc cref="AliasAddOperation.Alias"/>
		public AliasAddDescriptor Alias(string alias)
		{
			Self.Add.Alias = alias;
			return this;
		}

		/// <inheritdoc cref="AliasAddOperation.Routing"/>
		public AliasAddDescriptor Routing(string routing)
		{
			Self.Add.Routing = routing;
			return this;
		}

		/// <inheritdoc cref="AliasAddOperation.IndexRouting"/>
		public AliasAddDescriptor IndexRouting(string indexRouting)
		{
			Self.Add.IndexRouting = indexRouting;
			return this;
		}

		/// <inheritdoc cref="AliasAddOperation.SearchRouting"/>
		public AliasAddDescriptor SearchRouting(string searchRouting)
		{
			Self.Add.SearchRouting = searchRouting;
			return this;
		}

		/// <inheritdoc cref="AliasAddOperation.IsWriteIndex"/>
		public AliasAddDescriptor IsWriteIndex(bool? isWriteIndex = true)
		{
			Self.Add.IsWriteIndex = isWriteIndex;
			return this;
		}

		/// <inheritdoc cref="AliasAddOperation.IsHidden"/>
		public AliasAddDescriptor IsHidden(bool? isHidden = true)
		{
			Self.Add.IsHidden = isHidden;
			return this;
		}

		/// <inheritdoc cref="AliasAddOperation.Filter"/>
		public AliasAddDescriptor Filter<T>(Func<QueryContainerDescriptor<T>, QueryContainer> filterSelector)
			where T : class
		{
			Self.Add.Filter = filterSelector?.Invoke(new QueryContainerDescriptor<T>());
			return this;
		}
	}
}
