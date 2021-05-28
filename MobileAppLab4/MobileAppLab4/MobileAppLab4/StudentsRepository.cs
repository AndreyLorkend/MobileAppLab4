using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MobileAppLab4
{
    public class StudentsRepository
    {
        SQLiteConnection database;
        static object locker = new object();
        public StudentsRepository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Student>();
        }
        public IEnumerable<Student> GetItems()
        {
            return database.Table<Student>().ToList();
        }
        public Student GetItem(int id)
        {
            return database.Get<Student>(id);
        }
        public int DeleteItem(int id)
        {
            lock (locker)
            {
                return database.Delete<Student>(id);
            }
        }
        public int SaveItem(Student item)
        {
            if (item.id != 0)
            {
                database.Update(item);
                return item.id;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}
