using System.ComponentModel.DataAnnotations;
using Postgrest.Attributes;
using Supabase;

namespace BlazorVotingSupabase;

[Table(nameof(Vote))]
public class Vote : SupabaseModel
{
    [PrimaryKey("id", false)]
    public int Id { get; set; }

    [Column("name")]
    [Required]
    public string? Name { get; set; }

    [Column("email")]
    [Required]
    [EmailAddress]
    public string? Email { get; set; }

    [Column("answer")]
    public bool Answer { get; set; }
}
