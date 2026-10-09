using Microsoft.AspNetCore.Mvc;
using MVC_Project.Models;

namespace MVC_Project.Controllers;

public class PortfolioController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult IzeahPortfolio()
    {
        var model = new IzeahModel
        {
            Interests = ["android apps", "web apps", "linux", "nix", "proxmox", "docker", "godot"],
            TechStack =
            [
                new("web-related", ["HTML/CSS", "JS", "Bootstrap", "Next.js", "Tailwind"]),
                new("languages", ["C/C++", "Python", "Java"]),
                new("tools & data", ["PostgreSQL", "Supabase", "Git", "Linux", "Docker", "Vim/Neovim", "CI/CD"]),
            ],
            Projects =
            [
                new("Aya",
                    "An app that helps answer the question \"saan tayo?\" using group preference-based matching algorithms.",
                    "https://github.com/afkDen/iNet_GitHub"),
                new("Starship",
                    "A system that aims to solve the fractured data problem of rural schools using sms-based data collection",
                    "https://github.com/star-ship-project/starship-web"),
                new("PUPili",
                    "An offline-first lagoon food database with a live interactive map utilizing b-tree lookups for its database engine",
                    "https://github.com/izeaharquillano/pup-lagoon-app"),
            ],
            Experiences =
            [
                new("1st Runner-Up", "DOST START Hackathon", "Built and presented Starship as a backend developer"),
                new("6th Place", "SIKAPTala DLSU Hackathon", "Presented and contributed to Aya"),
            ],
        };
        return View(model);
    }
}