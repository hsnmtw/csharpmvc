using System;

namespace MVCWinform.Common {
    public class ProgressUpdate {
        public Action Updated { get; set; }
        public string Operation { get; private set; }
        public string Message { get; private set; }
        public int Progress { get; private set; }

        public ProgressUpdate(string operation) { Operation = operation; }
        public void SetProgress(string message,int progress) {
            Message = message;
            Progress = progress;
            Updated();
        }

        public override string ToString() {
            return string.Format("{0,-18} {1,-60} {2,3}%",Operation,Message,Progress);
        }
    }
}
