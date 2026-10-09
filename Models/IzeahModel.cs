namespace MVC_Project.Models;

public class IzeahModel
{
    public string? Location { get; set; }
    public List<string>? Interests  { get; set; }
    public List<IzeahDomains>? TechStack { get; set; }
    public List<IzeahProject>? IzeahProjects { get; set; }
    public List<IzeahExperience>? IzeahExperiences { get; set; }
}

public class IzeahDomains
{
    public string? DomainName { get; set; }
    public List<string>? Items { get; set; }
}

public class IzeahProject
{
   public string? Name {get; set; } 
   public string? Desc { get; set; }
   public string? Link { get; set; }
}

public class IzeahExperience
{
    public string? Name { get; set; }
    public string? Desc { get; set; }
    public string? Placement { get; set; }
}