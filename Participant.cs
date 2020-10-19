namespace EventPlatform
{
    class Participant : Person
    {
        /**参与人类**/

        public string School { get; set; } // 学院
        public int Grade { get; set; } // 年级
        public string Class { get; set; } //班级
        public List<Event> Events { get; set; } // 个人经历
    }
}
