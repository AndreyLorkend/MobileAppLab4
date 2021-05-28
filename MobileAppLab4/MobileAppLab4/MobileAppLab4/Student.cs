using System;
using SQLite;

namespace MobileAppLab4
{
    [Table("Students")]
    public class Student
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int id { get; set; }
        public string examName { get; set; }
        public string studentName { get; set; }
        public string studentSurname { get; set; }
        public DateTime examDate { get; set; }
        public int examMark { get; set; }
    }
}
