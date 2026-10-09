namespace MVC_Project.Models;

public class PortfolioModel
{
    private int _id;
    public int id
    {
        get
        {
            return _id;
        }
        set
        {
            if (value > 0)
            {
                _id = value;
            }
            else
            {
                throw new Exception("Wrong input in ID field");
            }
        }
    }

    // Personal Information 
    public required string firstName { get; set; }
    public string? middleName { get; set; }
    public string? lastName { get; set; }
    public string? photoLink { get; set; }

    // Contact Information
    public string? emailAddress { get; set; }
    public string? githubUsername { get; set; }
    public string? githubLink { get; set; }
    public string? linkedinUsername { get; set; }
    public string? linkedinLink { get; set; }
    
    // Background and Experience
    public string? bio { get; set; }  
    public List<string>? techStack { get; set; }
    public List<Experience>? Experiences { get; set; }
    public List<Project>? Projects { get; set; }
}

public class Experience {
        public string? company { get; set; }
        public string? position { get; set; }
        public string? startDate { get; set; }
        public string? endDate { get; set; }
        public string? description { get; set; }
    }

    public class Project {
        public string? name { get; set; }
        public List<string>? tools { get; set; }
        public string? description { get; set; }
        public string? projectLink {get; set; }
    }