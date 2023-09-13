using Spark.Library.Database;

namespace SparkDotnet8.Application.Models;

public class Role : BaseModel
{
    public Role()
    {
        UserRoles = new HashSet<UserRole>();
    }

    public string Name { get; set; }

    public virtual ICollection<UserRole> UserRoles { get; set; }
}
