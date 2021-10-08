using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Azure_Function_Basic_Example
{
	// 0/10 * * * * *	every 10 seconds
	// 10 * * * * *		every seconds 10
	// 30 * * * * *		every seconds 30
	public static class FunctionTimerTrigger1
	{
		[FunctionName("FunctionTimerTrigger1")]
		public static void Run([TimerTrigger("%scheduleExpression1%")] TimerInfo myTimer, ILogger log)
		{
			log.LogInformation($"{myTimer.Schedule} : {DateTime.Now}");
			log.LogInformation($"IsPastDue ? {myTimer.IsPastDue} : {DateTime.Now}");
			log.LogInformation($"FormatNextOccurrences : {myTimer.FormatNextOccurrences(1)}");
		}

	}

	public static class FunctionTimerTrigger2
	{
		[FunctionName("FunctionTimerTrigger2")]
		public static void Run([TimerTrigger("%scheduleExpression2%")] TimerInfo myTimer, ILogger log)
		{
			log.LogInformation($"{myTimer.Schedule} : {DateTime.Now}");
			log.LogInformation($"IsPastDue ? {myTimer.IsPastDue} : {DateTime.Now}");
			log.LogInformation($"FormatNextOccurrences : {myTimer.FormatNextOccurrences(1)}");
		}

	}
}
