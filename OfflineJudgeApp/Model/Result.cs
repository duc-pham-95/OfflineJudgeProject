using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfflineJudgeApp.Model
{
    class Result
    {
        public string Output { get; set; }
        public string Error { get; set; }
        public Result()
        {
            this.Output = "";
            this.Error = "";
        }
    }
}
