// // Antarmuka seragam untuk manusia
// interface IHuman
// {
//     string GetName();
//     int GetAge();
// }
// // Interface (IHuman):

// // Ini adalah Interface yang digunakan untuk mengakses informasi manusia dengan cara yang seragam.
// // Interface ini memiliki dua metode: GetName() untuk mendapatkan nama manusia dan GetAge() untuk mendapatkan usia manusia.
// // Semua adapter yang dibuat harus mengimplementasikan antarmuka ini.

// class Person
// {
//     public string Name { get; set; }
//     public int Age { get; set; }
// }
// // Kelas Person:

// // Ini adalah kelas yang mewakili manusia dengan atribut Name dan Age.
// // Kelas ini tidak sesuai dengan antarmuka IHuman, karena menggunakan nama properti yang berbeda.
// // Adapter untuk Person
// class PersonAdapter : IHuman
// {
//     private Person person;

//     public PersonAdapter(Person person)
//     {
//         this.person = person;
//     }

//     public string GetName()
//     {
//         return person.Name;
//     }

//     public int GetAge()
//     {
//         return person.Age;
//     }
// }

// // Adapter untuk Kelas Person (PersonAdapter):

// // Ini adalah adapter yang menghubungkan antarmuka IHuman dengan kelas Person.
// // Adapter ini menerima objek Person sebagai parameter konstruktor dan menyimpannya sebagai variabel anggota.
// // Untuk mengimplementasikan antarmuka IHuman, adapter ini menyediakan implementasi metode GetName() yang mengembalikan Name dari objek Person, dan metode GetAge() yang mengembalikan Age dari objek Person.
// // Kelas Employee
// class Employee
// {
//     public string FullName { get; set; }
//     public int YearsOfService { get; set; }
// }

// // Adapter untuk Employee
// class EmployeeAdapter : IHuman
// {
//     private Employee employee;

//     public EmployeeAdapter(Employee employee)
//     {
//         this.employee = employee;
//     }

//     public string GetName()
//     {
//         return employee.FullName;
//     }

//     public int GetAge()
//     {
//         // Menghitung usia berdasarkan tahun kerja
//         int currentYear = DateTime.Now.Year;
//         int birthYear = currentYear - employee.YearsOfService;
//         return currentYear - birthYear;
//     }
// }

// // Contoh penggunaan
// class Program
// {
//     static void Main(string[] args)
//     {
//         // Membuat instance manusia
//         Person person = new Person() { Name = "John Doe", Age = 30 };
//         Employee employee = new Employee() { FullName = "Jane Smith", YearsOfService = 5 };

//         // Membuat adapter untuk setiap manusia
//         IHuman personAdapter = new PersonAdapter(person);
//         IHuman employeeAdapter = new EmployeeAdapter(employee);

//         // Menggunakan antarmuka seragam untuk mengakses informasi manusia
//         DisplayHumanInformation(personAdapter);
//         DisplayHumanInformation(employeeAdapter);
//     }

//     static void DisplayHumanInformation(IHuman human)
//     {
//         Console.WriteLine("Name: " + human.GetName());
//         Console.WriteLine("Age: " + human.GetAge());
//         Console.WriteLine();
//     }
// }
