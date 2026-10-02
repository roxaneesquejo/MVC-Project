using System.ComponentModel.Design;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_Project.Models;

namespace MVC_Project.Controllers;

public class StudentController : Controller
{
    public IActionResult Index()
    {
        StudentModel stud = new StudentModel();
        stud.id = 1;
        stud.firstName = "Rox";
        stud.lastName = "Esquejo";
        stud.address = "address";
        stud.contactNum = "0123456789";
        stud.dateOfBirth = new DateOnly(2026, 01, 01);
        return View(stud);
    }

    public IActionResult StudentList()
    {
        List<StudentModel> studentList = new List<StudentModel>();
        studentList.Add(new StudentModel
        {
            id = 1,
            firstName = "Rox",
            lastName = "Esquejo",
            address = "address",
            contactNum = "0123456789",
            dateOfBirth = new DateOnly(2026, 01, 01),
        });
        studentList.Add(new StudentModel
        {
            id = 2,
            firstName = "Izeah",
            lastName = "Arquillano",
            address = "address",
            contactNum = "1123456789",
            dateOfBirth = new DateOnly(2026, 01, 02),
        });
        return View(studentList);
    }
}
