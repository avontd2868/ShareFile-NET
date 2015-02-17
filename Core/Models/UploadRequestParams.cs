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
	public class UploadRequestParams : ODataObject 
	{

		public SafeEnum<UploadMethod> Method { get; set; }

		public bool? Raw { get; set; }

		public string FileName { get; set; }

		public long? FileSize { get; set; }

		public string BatchId { get; set; }

		public bool? BatchLast { get; set; }

		public bool? CanResume { get; set; }

		public bool? StartOver { get; set; }

		public bool? Unzip { get; set; }

		public bool? Overwrite { get; set; }

		public string Opid { get; set; }

		public string Title { get; set; }

		public string Tool { get; set; }

		public string Details { get; set; }

		public bool? IsSend { get; set; }

		public string SendGuid { get; set; }

		public bool? Notify { get; set; }

		public int? ThreadCount { get; set; }

		public DateTime? ClientCreatedDate { get; set; }

		public DateTime? ClientModifiedDate { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as UploadRequestParams;
			if(typedSource != null)
			{
				Method = typedSource.Method;
				Raw = typedSource.Raw;
				FileName = typedSource.FileName;
				FileSize = typedSource.FileSize;
				BatchId = typedSource.BatchId;
				BatchLast = typedSource.BatchLast;
				CanResume = typedSource.CanResume;
				StartOver = typedSource.StartOver;
				Unzip = typedSource.Unzip;
				Overwrite = typedSource.Overwrite;
				Opid = typedSource.Opid;
				Title = typedSource.Title;
				Tool = typedSource.Tool;
				Details = typedSource.Details;
				IsSend = typedSource.IsSend;
				SendGuid = typedSource.SendGuid;
				Notify = typedSource.Notify;
				ThreadCount = typedSource.ThreadCount;
				ClientCreatedDate = typedSource.ClientCreatedDate;
				ClientModifiedDate = typedSource.ClientModifiedDate;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("Method", out token) && token.Type != JTokenType.Null)
				{
					Method = (SafeEnum<UploadMethod>)serializer.Deserialize(token.CreateReader(), typeof(SafeEnum<UploadMethod>));
				}
				if(source.TryGetProperty("Raw", out token) && token.Type != JTokenType.Null)
				{
					Raw = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("FileName", out token) && token.Type != JTokenType.Null)
				{
					FileName = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("FileSize", out token) && token.Type != JTokenType.Null)
				{
					FileSize = (long?)serializer.Deserialize(token.CreateReader(), typeof(long?));
				}
				if(source.TryGetProperty("BatchId", out token) && token.Type != JTokenType.Null)
				{
					BatchId = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("BatchLast", out token) && token.Type != JTokenType.Null)
				{
					BatchLast = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("CanResume", out token) && token.Type != JTokenType.Null)
				{
					CanResume = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("StartOver", out token) && token.Type != JTokenType.Null)
				{
					StartOver = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("Unzip", out token) && token.Type != JTokenType.Null)
				{
					Unzip = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("Overwrite", out token) && token.Type != JTokenType.Null)
				{
					Overwrite = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("Opid", out token) && token.Type != JTokenType.Null)
				{
					Opid = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("Title", out token) && token.Type != JTokenType.Null)
				{
					Title = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("Tool", out token) && token.Type != JTokenType.Null)
				{
					Tool = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("Details", out token) && token.Type != JTokenType.Null)
				{
					Details = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("IsSend", out token) && token.Type != JTokenType.Null)
				{
					IsSend = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("SendGuid", out token) && token.Type != JTokenType.Null)
				{
					SendGuid = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("Notify", out token) && token.Type != JTokenType.Null)
				{
					Notify = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("ThreadCount", out token) && token.Type != JTokenType.Null)
				{
					ThreadCount = (int?)serializer.Deserialize(token.CreateReader(), typeof(int?));
				}
				if(source.TryGetProperty("ClientCreatedDate", out token) && token.Type != JTokenType.Null)
				{
					ClientCreatedDate = (DateTime?)serializer.Deserialize(token.CreateReader(), typeof(DateTime?));
				}
				if(source.TryGetProperty("ClientModifiedDate", out token) && token.Type != JTokenType.Null)
				{
					ClientModifiedDate = (DateTime?)serializer.Deserialize(token.CreateReader(), typeof(DateTime?));
				}
			}
		}
	}
}