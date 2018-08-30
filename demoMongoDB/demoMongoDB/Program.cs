using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoMongoDB
{
    class Program
    {
        static void Main(string[] args)
        {
            const string connectionString = "mongodb://earn:e09545321@ds135952.mlab.com:35952/mydemo";
            const string databaseName = "mydemo";
            const string collectionStudentName = "myCollection";
            const string collectionTeacherName = "myTeacherCollection";
            const string collectionRoomName = "myRoomCollection";

            Console.WriteLine("Connecting database");
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);

            var collection = database.GetCollection<Student>(collectionStudentName);
            var collectionTeacher = database.GetCollection<Teacher>(collectionTeacherName);
            var collectionRoom = database.GetCollection<Room>(collectionRoomName);

            #region Basic

            // Insert
            //Console.WriteLine("Insert data");
            //collection.InsertOne(new Student
            //{
            //    Id = "002",
            //    Name = "sorry",
            //    Score = 80
            //});

            // Get list
            //Console.WriteLine("Finding collection member");
            //var resultList = collection.Find(it => true).ToList();
            //Console.WriteLine(resultList.Count);

            // Get One
            //var resultOne = collection.Find(it => it.Id == "001").FirstOrDefault();
            //Console.WriteLine("Name: " + resultOne.Name);

            // Update
            //collection.ReplaceOne(it => it.Id == "001", new Student
            //{
            //    Id = "001",
            //    Name = "ChangeName",
            //    Score = 99999
            //});

            //var resultList = collection.Find(it => true).ToList();
            //Console.WriteLine(resultList.Count);

            //collection.DeleteOne(it => it.Id == "001");

            #endregion Basic
            
            #region Advances

            //collectionRoom.InsertOne(new Room
            //{
            //    Id = "R01",
            //    TeacherIds = "T01",
            //    StudentIds = new List<string>
            //    {
            //        "001", "002"
            //    }
            //});

            // ดูห้องทั้งหมดใน collectionRoom แล้วเลือก Room ที่ Teacher รหัส T01 สอนในห้องอยู่
            //var room = collectionRoom.Find(it => it.TeacherIds == "T01").FirstOrDefault();

            // ดูรายชื่อนักเรียนทั้งหมด (collection) แล้วเลือกเฉพาะนักเรียนที่มีรายชื่อจากห้องข้างบนดังกล่าว
            //var result = collection.Find(it => room.StudentIds.Contains(it.Id)).ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Name);
            //}

            #endregion Advances
        }
    }

    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
    }

    public class Teacher
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Tech { get; set; }
    }

    public class Room
    {
        public string Id { get; set; }
        public string TeacherIds { get; set; }
        public List<string> StudentIds { get; set; }
    }
}
