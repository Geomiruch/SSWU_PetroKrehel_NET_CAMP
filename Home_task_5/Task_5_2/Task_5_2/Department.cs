using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_2
{
    internal class Department
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }
        public List<Department> SubDepartments { get; set; }

        public Department(string name)
        {
            Name = name;
            Products = new List<Product>();
            SubDepartments = new List<Department>();
        }

        public void AddProduct(Product product, List<string> path)
        {
            if(path.Count>0)
            {
                Department subDepartment = SubDepartments.Find(x => x.Name == path[0]);
                if(subDepartment==null)
                {
                    subDepartment = new Department(path[0]);
                    this.AddSubDepartment(subDepartment);
                    
                }
                path.Remove(path[0]);
                subDepartment.AddProduct(product, path);
            }
            else if ((Products.Find(x=>x.Name==product.Name))==null)
            {
                Products.Add(product);
            }
        }

        public void AddSubDepartment(Department department)
        {
            if (SubDepartments.Find(x => x.Name == department.Name)==null)
            {
                SubDepartments.Add(department);
            }
        }

        public Box PackDepartmentBox()
        {
            Box departmentBox = new Box(Name, 0, 0, 0);
            foreach (Product product in Products)
            {
                Box productBox = product.PackProductInBox();
                departmentBox.Width += product.Width;
                departmentBox.Height = Math.Max(departmentBox.Height, product.Height);
                departmentBox.Length = Math.Max(departmentBox.Length, product.Length);
                departmentBox.AddObject(productBox);
            }
            foreach (Department subDepartment in SubDepartments)
            {
                Box subDepartmentBox = subDepartment.PackDepartmentBox();
                departmentBox.Width += subDepartmentBox.Width;
                departmentBox.Height = Math.Max(departmentBox.Height, subDepartmentBox.Height);
                departmentBox.Length = Math.Max(departmentBox.Length, subDepartmentBox.Length);
                departmentBox.AddObject(subDepartmentBox);
            }
            return departmentBox;
        }

        public void PrintProducts(string path)
        {
            path = path + Name+"/";
            if(Products.Any())
            {
                foreach(Product product in Products)
                {
                    Console.WriteLine(path+product.ToString());
                }
            }
            if(SubDepartments.Any())
            {
                foreach(Department subDepartment in SubDepartments)
                {
                    subDepartment.PrintProducts(path);
                }
            }    
        }
    }
}
