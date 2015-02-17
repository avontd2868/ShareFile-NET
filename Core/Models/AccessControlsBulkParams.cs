// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     
//	   Copyright (c) 2015 Citrix ShareFile. All rights reserved.
// </auto-generated>
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ShareFile.Api.Client.Extensions;

namespace ShareFile.Api.Models 
{
	public class AccessControlsBulkParams : ODataObject 
	{

		/// <summary>
		/// Defines whether the principal should receieve a notice on the permission grant.
		/// If an AccessControlParam doesn't specify the property it is inherited from here.
		/// </summary>
		public bool? NotifyUser { get; set; }

		/// <summary>
		/// Custom notification message, if any
		/// If an AccessControlParam doesn't specify the property it is inherited from here.
		/// </summary>
		public string NotifyMessage { get; set; }

		/// <summary>
		/// AccessControlParams
		/// </summary>
		public IEnumerable<AccessControlParam> AccessControlParams { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as AccessControlsBulkParams;
			if(typedSource != null)
			{
				NotifyUser = typedSource.NotifyUser;
				NotifyMessage = typedSource.NotifyMessage;
				AccessControlParams = typedSource.AccessControlParams;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("NotifyUser", out token) && token.Type != JTokenType.Null)
				{
					NotifyUser = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("NotifyMessage", out token) && token.Type != JTokenType.Null)
				{
					NotifyMessage = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("AccessControlParams", out token) && token.Type != JTokenType.Null)
				{
					AccessControlParams = (IEnumerable<AccessControlParam>)serializer.Deserialize(token.CreateReader(), typeof(IEnumerable<AccessControlParam>));
				}
			}
		}
	}
}