﻿using System.Text.Json;
using Json.Patch;
using TryJsonEverything.Services;
#pragma warning disable 8618

namespace TryJsonEverything.Models
{
	[Schema(typeof(InputValidationSchemas), nameof(InputValidationSchemas.PatchInputSchema))]
	public class PatchProcessInput
	{
		public JsonDocument Data { get; set; }
		public JsonPatch Patch { get; set; }
	}
}