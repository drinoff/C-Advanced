using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        private List<Student> data;
        public int Capacity { get; set; }
        public int Count
        {
            get
            {
                return this.data.Count;
            }
        }
        public Classroom(int capacity)
        {
            this.Capacity = capacity;
            this.data = new List<Student>();
        }
        public string RegisterStudent(Student student)
        {
            if (this.Capacity > this.data.Count)
            {
                this.data.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
            else
            {
                return $"No seats in the classroom";
            }
        }
        public string DismissStudent(string firstname, string lastname)
        {
            var studentForDismissing = this.data.Find(x => x.FirstName == firstname && x.LastName == lastname);
            if (this.data.Contains(studentForDismissing))
            {
                this.data.Remove(studentForDismissing);
                return $"Dismissed student {studentForDismissing.FirstName} {studentForDismissing.LastName}";
            }
            else
            {
                return $"Student not found";
            }
        }
        public string GetSubjectInfo(string subject)
        {

            var sb = new StringBuilder();
            var withGivenSubj = this.data.Where(x => x.Subject == subject).ToList();
            if (withGivenSubj.Count > 0)
            {
                sb.AppendLine($"Subject: {subject}");
                sb.AppendLine("Students:");

                foreach (var student in withGivenSubj)
                {
                    sb.AppendLine($"{student.FirstName} {student.LastName}");
                }
            }
            else
            {
                sb.AppendLine("No students enrolled for the subject");
            }
            return sb.ToString().Trim();

        }
        public int GetStudentCount() => this.data.Count;
        public Student GetStudent(string firstName, string lastName) => this.data.Find(x => x.FirstName == firstName && x.LastName == lastName);

    }
}
