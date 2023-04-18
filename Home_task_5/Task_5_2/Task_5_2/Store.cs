using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_2
{
    internal class Store
    {
        public string Name { get; private set; }
        public List<Department> departments;

        public Store(string name)
        {
            Name = name;
            departments = new List<Department>();
        }

        public void AddDepartment(Department department)
        {
            if (departments.Find(x => x.Name == department.Name) == null)
            {
                departments.Add(department);
            }
        }
        //public Box PackStoreBox()
        //{
        //    Box storeBox = new Box(Name, 0, 0, 0);
        //    foreach (Department department in departments)
        //    {
        //        Box departmentBox = department.PackDepartmentBox();
        //        storeBox.Width += departmentBox.Width;
        //        storeBox.Height = Math.Max(storeBox.Height, departmentBox.Height);
        //        storeBox.Length = Math.Max(storeBox.Length, departmentBox.Length);
        //        storeBox.AddObject(departmentBox);
        //    }
        //    return storeBox;
        //}

        public void PrintBoxes(Box box)
        {
            box.PrintBoxInfo();
            foreach(object obj in box.Contents)
            {
                if (obj is Box)
                {
                    PrintBoxes((Box)obj);
                }
            }
        }
    }
}
