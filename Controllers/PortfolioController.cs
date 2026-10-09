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
            resumeLink = "~/ESQUEJO_RESUME.pdf",
            location = "Manila, Philippines",
            status = "Balancing my workload",

            emailAddress = "roxanek.esquejo@gmail.com",
            githubUsername = "roxaneesquejo",
            githubLink = "https://github.com/roxaneesquejo/",
            linkedinUsername = "roxaneesquejo",
            linkedinLink = "https://ph.linkedin.com/in/roxaneesquejo",

            bio = "I am currently a 3rd year Computer Science Student at the Polytechnic University of the Philippines. I enjoy building web applications and interactive games.",
            TechStack = new List<Technologies>
            {
                new Technologies
                {
                    category = "Programming",
                    tool = ["C", "Java", "TypeScript", "SQL", "HTML/CSS"],      
                },

                new Technologies
                {
                    category = "Frameworks & Libraries",
                    tool = ["React", "Next.js", "Node.js", "Flutter"],
                },

                new Technologies
                {
                    category = "Databases & Deployment",
                    tool = ["PostgreSQL", "Supabase", "Vercel"],
                },

                new Technologies
                {
                    category = "Tools",
                    tool = ["Git", "GitHub", "Docker Compose", "VS Code", "Antigravity"],
                }
            },

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
                },
                
                new Project
                {
                    name = "PUP ASCII Website",
                    tools = ["TypeScript", "React", "Node.js"],
                    description = "Developed the frontend architecture for the official PUP-ASCII website using TypeScript.",
                    projectLink = "https://github.com/jhonroyilao/pupascii-website"
                },

                new Project
                {
                    name = "Matrix Cofactor Calculator",
                    tools = ["TypeScript", "Vercel"],
                    description = "Led the development of a web-based linear algebra calculator using React and TypeScript to recursively compute determinants via cofactor expansion for up to 10×10 matrices.",
                    projectLink = "https://github.com/roxaneesquejo/matrix-cofactor-calculator"
                },

                new Project
                {
                    name = "Split: Bill-Splitting Utility",
                    tools = ["JavaScript", "React", "Vercel"],
                    description = "Led the development of a web-based linear algebra calculator using React and TypeScript to recursively compute determinants via cofactor expansion for up to 10×10 matrices.",
                    projectLink = "Developed a single-page expense-splitting web utility using React to automate group balance calculations, in isolated charges, and individual discount deductions."
                } 
            },
        };
     
        return View(RoxanePortfolio);
    }
}
