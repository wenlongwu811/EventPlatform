using System;
using System.Collections.Generic;
using System.Globalization;

namespace EventPlatform
{
    class Event
    {
        public uint ID { get; set; }
        public string Name { get; set; }
        public string Rank { get; set; } // 活动性质
        public DateTime EventStartTime { get; set; } // 活动开始时间
        public DateTime EventEndTime { get; set; } // 活动结束时间
        public DateTime SignUpStartTime { get; set; } // 报名开始时间
        public DateTime SignUpEndTime { get; set; } // 报名结束时间
        public string Address { get; set; } // 活动举办地址

        // TODO: 确认Detail的类，如果需要上传文件的话应该改成什么类呢？
        public string Detail { get; set; } // 活动其他细节（报名条件，活动标准，活动具体内容和流程）
        public Sponsor Sponsor { get; set; } // 主办方
        public List<Participant> Participants{get;set;} //参与人员表
    }
}
