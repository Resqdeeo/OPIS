using Shablonizator;
using Shablonizator.Models;

Console.WriteLine(PhrasesToStudents.Ex1("Лейсан"));
Console.WriteLine();
Console.WriteLine(PhrasesToStudents.Ex2(new StudentEx2 { Address = "Ул.Пушкина" }));
Console.WriteLine();
Console.WriteLine(PhrasesToStudents.Ex3(new StudentEx3()));
Console.WriteLine();

var table = new Table();
table.Students.Add(new StudentForTable { Fio = "Александр Никифоров", Grade = 0 });
table.Students.Add(new StudentForTable { Fio = "Антон Никулин", Grade = 100 });
table.Students.Add(new StudentForTable { Fio = "Петр Николаев", Grade = 71 });
table.Students.Add(new StudentForTable { Fio = "Даниил Тетерин", Grade = 56 });

Console.WriteLine(PhrasesToStudents.Ex4(table));