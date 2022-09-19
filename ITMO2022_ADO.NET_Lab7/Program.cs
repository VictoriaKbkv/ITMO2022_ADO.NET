using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO2022_ADO.NET_Lab7
{
    internal class Program
    {
        static List<Student> students = new List<Student>
        {
           new Student {First="Svetlana", Last="Omelchenko", ID=111, Scores= new List<int> {97, 92, 81, 60}},
           new Student {First="Claire", Last="O’Donnell", ID=112, Scores= new List<int> {75, 84, 91, 39}},
           new Student {First="Ivan", Last="Ivanov", ID=113, Scores= new List<int> {98, 84, 55, 39}},
        };

        static void Main(string[] args)
        {
            IEnumerable<Student> studentQuery =
                from student in students
                where student.Scores[0] > 90 && student.Scores[3] < 80
                orderby student.Scores[0] descending
                select student;

            var studentQuery2 =
                from student in students
                group student by student.Last[0];

            var studentQuery3 =
                from student in students
                group student by student.Last[0];

            var studentQuery4 =
                from student in students
                group student by student.Last[0] into studentGroup
                orderby studentGroup.Key
                select studentGroup;

            var studentQuery5 =
                from student in students
                let totalScore = student.Scores[0] + student.Scores[1] + student.Scores[2] + student.Scores[3]
                where totalScore / 4 < student.Scores[0]
                select student.Last + " " + student.First;


            var studentQuery6 =
                    from student in students
                    let totalScore = student.Scores[0] + student.Scores[1] + student.Scores[2] + student.Scores[3]
                    select totalScore;

            double averageScore = studentQuery6.Average();

            IEnumerable<string> studentQuery7 =
                    from student in students
                    where student.Last == "Garcia"
                    select student.First;

            
            var studentQuery8 =
                    from student in students
                    let x = student.Scores[0] + student.Scores[1] + student.Scores[2] + student.Scores[3]
                    where x > averageScore
                    select new { id = student.ID, score = x };



            foreach (var item in studentQuery8)
            {
                Console.WriteLine("Student ID: {0}, Score: {1}", item.id, item.score);
            }


        }
    }
}
