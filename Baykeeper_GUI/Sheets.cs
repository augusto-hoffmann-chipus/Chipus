using System;
using System.Collections.Generic;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;

namespace Baykeeper_GUI
{
	public partial class Sheets_Baykeeper
	{
		public IList<object> getSheetInfo(string sampleID)
		{
			string[] Scopes = { SheetsService.Scope.SpreadsheetsReadonly };

			try
			{
				UserCredential credential;
				// Load client secrets.
				using (var stream =
					   new FileStream("./../../tokens/credentials.json", FileMode.Open, FileAccess.Read))
				{
					/* The file token.json stores the user's access and refresh tokens, and is created
                     automatically when the authorization flow completes for the first time. */
					string credPath = "./../../tokens/token.json";
					credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
						GoogleClientSecrets.FromStream(stream).Secrets,
						Scopes,
						"user",
						CancellationToken.None,
						new FileDataStore(credPath, true)).Result;
					Console.WriteLine("Credential file saved to: " + credPath);
				}

				// Create Google Sheets API service.
				var service = new SheetsService(new BaseClientService.Initializer
				{
					HttpClientInitializer = credential,
					ApplicationName = "Baykeeper"
				});

				// Define request parameters.
				String spreadsheetId = "1nrimacS-JrVaQyCF6g81gbc9vLpQ-qfbbJhotFv5J1Y";
				String range = "Sheet1!A:C";
				SpreadsheetsResource.ValuesResource.GetRequest request =
					service.Spreadsheets.Values.Get(spreadsheetId, range);

				// Prints the names and majors of students in a sample spreadsheet:
				// https://docs.google.com/spreadsheets/d/1BxiMVs0XRA5nFMdKvBdBZjgmUUqptlbs74OgvE2upms/edit
				ValueRange response = request.Execute();
				IList<IList<Object>> values = response.Values;
				if (values == null || values.Count == 0)
				{
					Console.WriteLine("No data found.");
					return null;
				}
				var i = 0;
				foreach (var row in values)
				{

					if (sampleID == (string)row[0])
						return row;
					i++;

				}
			}
			catch (FileNotFoundException e)
			{
				Console.WriteLine(e.Message);
				return null;
			}
			return null;
		}
	}
}
