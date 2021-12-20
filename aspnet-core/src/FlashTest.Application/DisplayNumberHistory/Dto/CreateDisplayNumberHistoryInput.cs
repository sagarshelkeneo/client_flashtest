using System;
using System.Collections.Generic;
using System.Text;

namespace FlashTest.DisplayNumberHistory.Dto
{
    public class CreateDisplayNumberHistoryInput
    {
        public int UserId { get; set; }
        public int InputNumber { get; set; }
        public string OutputResult { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
