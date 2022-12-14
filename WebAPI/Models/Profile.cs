namespace WebAPI.Models;

/// <summary>
/// A class representing the profile of a comicvine user
/// </summary>
public class Profile
{
    /// <summary>
    /// The name of the user
    /// </summary>
    public string? UserName { get; set; }
    /// <summary>
    /// The Url of the users profile picture
    /// </summary>
    public string? AvatarUrl { get; set; }
    /// <summary>
    /// The description on a users profile
    /// </summary>
    public string? ProfileDescription { get; set; }
    /// <summary>
    /// Number of post a user has made on the forum
    /// </summary>
    public int ForumPosts { get; set; }
    /// <summary>
    /// Number of wiki points a user has
    /// </summary>
    public int WikiPoints { get; set; }
    /// <summary>
    /// The people the user is currently following
    /// </summary>
    public LinkPreview? Following { get; set; }
    /// <summary>
    /// The people following the current user
    /// </summary>
    public LinkPreview? Followers { get; set; }
    /// <summary>
    /// An optional cover picture on the user profile
    /// </summary>
    public string? CoverPicture { get; set; }
    /// <summary>
    /// The background image of the profile header
    /// </summary>
    public string? BackgroundImage { get; set; }
   /// <summary>
   /// The about me section of a users profile
   /// </summary>
    public About? AboutMe { get; set; }
   /// <summary>
   /// The most recent activities the user engaged in
   /// </summary>
    public UserActivity[]? Activities { get; set; }
    // public LinkPreview[]? TopRatedLists { get; set; }
}