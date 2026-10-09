namespace MVC_Project.Models;

public record TechDomain(string Name, List<string> Items);
public record Project(string Name, string Desc, string Link);
public record Experience(string Placement, string Name, string Desc);

public class IzeahModel
{
    public List<string>? Interests  { get; set; }
    public List<TechDomain>? TechStack { get; set; }
    public List<Project>? IzeahProjects { get; set; }
    public List<Experience>? IzeahExperiences { get; set; }
}