namespace Task_5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store("Магазин");
            Console.WriteLine("Ви в режимі створення структури магазину");
            Department mainDepartment = new Department(store.Name);
            while (true)
            {
                Console.WriteLine("Введіть товар в форматі: назва ширина висота довжина відділ_1/відділ_2.../відділ_N");
                Console.WriteLine("Для завершення створення структури введіть 0");
                string answer = Console.ReadLine();
                if (answer=="0")
                {
                    break;
                }
                string product = answer;
                string[] splitted = product.Split(' ');
                Product currentProduct = new Product(splitted[0], Convert.ToDouble(splitted[1]), Convert.ToDouble(splitted[2]), Convert.ToDouble(splitted[3]));
                List<string> path = splitted[4].Split('/').ToList<string>();
                mainDepartment.AddProduct(currentProduct, path);
            }
            store.AddDepartment(mainDepartment);

            Console.WriteLine("Список товарів з їх шляхом: ");
            mainDepartment.PrintProducts("");

            Console.WriteLine("Список коробок з їх вмістом: ");
            Box storeBox = mainDepartment.PackDepartmentBox();
            store.PrintBoxes(storeBox);

            

            Console.WriteLine();
        }
    }
}