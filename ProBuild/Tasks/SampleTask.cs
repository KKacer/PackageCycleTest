//using Microsoft.Build.Framework;
//using Microsoft.Build.Utilities;
//using ProDevelopers.Common;

//namespace ProDevelopers.ProBuild.Tasks
//{
//    public class SampleTask : Task
//    {
//        public TaskResult TaskResult { get; set; }
//        public override bool Execute()
//        {
//            switch (TaskResult.Result)
//            {
//                case TaskResultType.Success:
//                    Log.LogMessage(importance: MessageImportance.High, "==== TrelloMailTask ran successfully! ");
//                    Log.LogMessage(importance: MessageImportance.High, "==== Trello record created successfully! ");
//                    return true;
//                case TaskResultType.Fail:
//                    Log.LogError(TaskResult.ErrorMessage);
//                    return false;
//            }

//            return true;
//        }
//    }
//}
