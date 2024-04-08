using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskStudent.Models
{
    internal class Group
    {
        public static Group[] Groups;
        public static int GroupCaunt{ get; set; }
        public int GroupId { get; set; }
        public string Name { get; set; }
        public Student[] Students;

        public Group(string groupname)
        {
            Name= groupname;
            Groups = new Group[0];
            Students= new Student[0];
            GroupId = ++GroupCaunt;
        }

        public  void GetGroupInfo()
        {
            Console.WriteLine($"GROUP:{Name}\nGroupId:{GroupId}");
            foreach (var student in Students)
            {
                student.GetInfo(); 
            }

        }
        public Student GetStudent(int id)
        {
            foreach (Student item in Students)
            {
                if (item.Id==id)
                {
                    return item;
                }
            }
            return null;
        }



        public void AddStudent(Student student)
        {
            Array.Resize(ref Students,Students.Length+1);
            Students[Students.Length-1] = student;
        }

        public void Searc(string query)
        {
            foreach (Student item in Students)
            {
                if (item.Name==query ||item.Surname==query )  
                {
                    item.GetInfo();

                }
            }
        }
       
        public void Search(string query)
        {
            var results = Students.Where(s => s.Name.Contains(query) || s.Surname.Contains(query));
            foreach (var student in results)
            {
                student.GetInfo();
            }
        }
        public void ShowStudents(Student student)
        {
            foreach (var item in Students)
            {
                item.GetInfo();
            }

        }
        public override string ToString()
        {
            return $"Group Name{Name}\nGroup Id{GroupId}";
        }

        public static void AddGroup(Group group)
        {
            Array.Resize(ref Groups,Groups.Length+1);
            Groups[Groups.Length-1]= group;
        }
        public static void RemoveGroup(int id)
        {
            var NewArr=new Group[Groups.Length-1];
            int j = 0;
            for (int i = 0; i <Groups.Length;  i++)
            {
                if (Groups[i].GroupId==id)
                {
                    NewArr[j] = Groups[i];
                    j++;
                }
            }
            Groups=NewArr;
        }
        public static Group GetGroup(int id)
        {
            foreach (Group group in Groups)
            {
                if (group.GroupId==id)
                {
                    return group;
                }
            }
            return null;
            
        }




    }
}
