using Microsoft.AspNetCore.Mvc;


namespace Project7.Controllers{
public class Name :Controller
{
public IActionResult Namesd(){
   
   List<nStudents> nstudent=new List<nStudents>();
   nstudent.Add(new nStudents(){Id=1,Name="بهمن",Namef="شفیعی",Number=15});
   nstudent.Add(new nStudents(){Id=2,Name="قاسم",Namef="رجبی",Number=15});
   nstudent.Add(new nStudents(){Id=3,Name="ابوالفضل",Namef="قاسمی",Number=18});
   nstudent.Add(new nStudents(){Id=4,Name="امیرحسین",Namef="مشایخی",Number=19});
   nstudent.Add(new nStudents(){Id=5,Name="محمدحسین",Namef="جاویدمهر",Number=20});
   nstudent.Add(new nStudents(){Id=6,Name="محمد",Namef="کاظمی",Number=18});
   nstudent.Add(new nStudents(){Id=7,Name="امین",Namef="حاتمی",Number=19});
   nstudent.Add(new nStudents(){Id=8,Name="میکائیل",Namef="حسین آبادی",Number=20});
   nstudent.Add(new nStudents(){Id=9,Name="مبین",Namef="حسنی",Number=18});
   nstudent.Add(new nStudents(){Id=10,Name="یونس",Namef="اسدالهی",Number=19});
   nstudent.Add(new nStudents(){Id=11,Name="محمد",Namef="محمدی",Number=20});
   nstudent.Add(new nStudents(){Id=12,Name="میثم",Namef="مبینی",Number=18});
   nstudent.Add(new nStudents(){Id=13,Name="محمدمهدی",Namef="رستمی",Number=19});
   nstudent.Add(new nStudents(){Id=14,Name="حسین",Namef="افسونی",Number=20});
   
    return View(nstudent);
} 
}}