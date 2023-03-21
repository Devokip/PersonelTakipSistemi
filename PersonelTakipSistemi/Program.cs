using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonelTakipSistemi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Personel takip verileri oluşturma
            var rnd = new Random();
            var departments = new List<string> { "Muhasebe", "İnsan Kaynakları", "Pazarlama", "Satış" };
            var names = new List<string> { "Ahmet", "Mehmet", "Ali", "Ayşe", "Fatma", "İbrahim", "Emre", "Aylin", "Zeynep", "Deniz" };
            var surnames = new List<string> { "Yılmaz", "Demir", "Çelik", "Öztürk", "Kaya", "Arslan", "Doğan", "Çetin", "Kılıç", "Özcan" };
            var positions = new List<string> { "Stajyer", "Uzman", "Yönetici", "Müdür", "Genel Müdür" };
            var employees = new List<Employee>();

            for (int i = 0; i < 50; i++)
            {
                var employee = new Employee
                {
                    Name = names[rnd.Next(names.Count)],
                    Surname = surnames[rnd.Next(surnames.Count)],
                    Department = departments[rnd.Next(departments.Count)],
                    Position = positions[rnd.Next(positions.Count)],
                    Salary = rnd.Next(2000, 10000),
                    HireDate = DateTime.Now.AddDays(-rnd.Next(365 * 5)),
                    LastEvaluation = DateTime.Now.AddDays(-rnd.Next(365)),
                    IsActive = rnd.Next(2) == 1
                };

                employees.Add(employee);
            }

            // Oluşturulan verileri konsola yazdırma
            foreach (var employee in employees)
            {
                Console.WriteLine($"Adı: {employee.Name} {employee.Surname}");
                Console.WriteLine($"Departmanı: {employee.Department}");
                Console.WriteLine($"Pozisyonu: {employee.Position}");
                Console.WriteLine($"Maaşı: {employee.Salary}");
                Console.WriteLine($"İşe Giriş Tarihi: {employee.HireDate.ToShortDateString()}");
                Console.WriteLine($"Son Değerlendirme Tarihi: {employee.LastEvaluation.ToShortDateString()}");
                Console.WriteLine($"Aktif mi?: {employee.IsActive}");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime LastEvaluation { get; set; }
        public bool IsActive { get; set; }
    }
}
