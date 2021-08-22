 using System.Collections.Generic;
using System.IO;
 using Microsoft.AspNetCore.Http;
 using Microsoft.AspNetCore.Mvc;
 using Microsoft.Azure.WebJobs;
 using Microsoft.Azure.WebJobs.Extensions.Storage;

 public static class GetSettingInfo
 {
     [FunctionName("GetSettingInfo")]
     public static IActionResult Run(
         [HttpTrigger("GET")] HttpRequest request,
         [Blob("content/settings.json")] string json)
         => new OkObjectResult(json);
 }
