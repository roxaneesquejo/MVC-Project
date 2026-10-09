using System.ComponentModel.Design;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_Project.Models;

namespace MVC_Project.Controllers;

public class PortfolioController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult RoxanePortfolio()
    {
       PortfolioModel RoxanePortfolio = new PortfolioModel()
       {
            id = 1,

            firstName = "Roxane K-Anne",
            middleName = "Donor",
            lastName = "Esquejo",
            photoLink = "~/images/ESQUEJO_BG.png",

            emailAddress = "roxanek.esquejo@gmail.com",
            githubUsername = "roxaneesquejo",
            githubLink = "https://github.com/roxaneesquejo/",
            linkedinUsername = "roxaneesquejo",
            linkedinLink = "https://ph.linkedin.com/in/roxaneesquejo",

            bio = "I am currently a 3rd year Computer Science Student at the Polytechnic University of the Philippines. I enjoy building web applications and interactive games.",
            techStack = ["C", "Java", "TypeScript", "SQL", "HTML/CSS"],

            Experiences = new List<Experience>
            {
                new Experience
                {
                    company = "PUP Association of Students for Computer Intelligence Integration",
                    position = "Vice President for Research and Extensions",		
                    startDate = "August 2026",
                    endDate = "Present",
                    description = "PUP-ASCII is the official academic organization of PUP Department of Computer Science. I head the Research and Extensions Committee, managing both partnerships and writing aspect of the organization."
                },

                new Experience
                {
                    company = "ARK Studio",
                    position = "Game Development - Audio Design Lead",
                    startDate = "August 2025",
                    endDate = "Present",
                    description = "ARK Studio is a student-led organization dedicated to Game Development. I lead audio design initiatives within the game development team, collaborating with developers and designers to support gameplay and production."
                },

                new Experience
                {
                    company = "PUP College of Computer and Information Sciences",
                    position = "Immersionist",
                    startDate = "February 2024",
                    endDate = "May 2024",
                    description = "Inside the CCIS Faculty, I helped organize  departmental records, maintaining secure filing systems and routing critical documents across university offices in accordance with institutional records-management procedures."
                }
            },

            Projects = new List<Project>
            {
                new Project
                {
                    name = "EcoEcho: Social Environment Application",
                    tools = ["Flutter", "Node.js", "PostgreSQL", "Vercel"],
                    description = "EcoEcho is a gamefied platform dedicated to encouraging sustainable practices for its users.",
                    projectLink = "https://github.com/EcoEcho-DAA/EcoEcho"
                }  
            },
        };
     
        return View(RoxanePortfolio);
    }
}
