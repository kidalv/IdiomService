using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IdiomsService.Database.Models
{
    public class Language
    {
        [Key]
        public int LanguageId { get; set; }
        [Required]
        public string Name { get; set; }
        public string NativeName { get; set; }
        public string Locale { get; set; }
        public string RegionCode { get; set; }
    }

    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime Registered { get; set; }
        [Required]
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public bool IsGoogle { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<UserLanguage> Languages { get; set; }
        public ICollection<Favorite> Favorites { get; set; }
        public ICollection<Upvote> Upvotes { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Report> Reports { get; set; }
        public ICollection<Request> Requests { get; set; }
    }

    public class UserLanguage
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        public User User { get; set; }
        [Required]
        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }

    public class Idiom
    {
        [Key]
        public int IdiomId { get; set; }
        [Required]
        public string Text { get; set; }
        public string Meaning { get; set; }
        public string Usage { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime DateAdded { get; set; }
        [Column(TypeName = "date")]
        public DateTime DateChanged { get; set; }
        [Required]
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        [Required]
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<Favorite> Favorites { get; set; }
        public ICollection<Upvote> Upvotes { get; set; }
        public ICollection<Request> Requests { get; set; }
        public ICollection<Comment> Comment { get; set; }
        public ICollection<Report> Report { get; set; }
        public ICollection<Link> Links { get; set; }
    }

    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        [Required]
        public string Text { get; set; }
        [Column(TypeName = "date")]
        public DateTime DateAdded { get; set; }
        [Required]
        public int UserId { get; set; }
        public User User { get; set; }
        [Required]
        public int IdiomId { get; set; }
        public Idiom Idiom { get; set; }
        public ICollection<CommentLike> CommentLikes { get; set; }
    }

    public class Favorite
    {
        [Key]
        public int FavoriteId { get; set; }
        [Required]
        public int UserId { get; set; }
        public User User { get; set; }
        [Required]
        public int IdiomId { get; set; }
        public Idiom Idiom { get; set; }
    }

    public class Upvote
    {
        [Key]
        public int UpvoteId { get; set; }
        [Required]
        public bool IsUpvote { get; set; }
        [Required]
        public int UserId { get; set; }
        public User User { get; set; }
        [Required]
        public int IdiomId { get; set; }
        public Idiom Idiom { get; set; }
    }

    public class Report
    {
        [Key]
        public int ReportId { get; set; }
        public string Text { get; set; }
        [Required]
        public int UserId { get; set; }
        public User User { get; set; }
        [Required]
        public int IdiomId { get; set; }
        public Idiom Idiom { get; set; }
    }

    public class Request
    {
        [Key]
        public int RequestId { get; set; }
        [Required]
        public int UserId { get; set; }
        public User User { get; set; }
        [Required]
        public int IdiomId { get; set; }
        public Idiom Idiom { get; set; }
        [Required]
        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }

    public class Link
    {
        [Key]
        public int LinkId { get; set; }
        [Required]
        public int LinkTypeId { get; set; }
        public LinkType LinkType { get; set; }
        [Required]
        public int RootId { get; set; }
        public Idiom Root { get; set; }
        [Required]
        public int RelatedId { get; set; }
        public Idiom Related { get; set; }
    }

    public class LinkType
    {
        [Key]
        public int LinkTypeId { get; set; }
        [Required]
        public string Name { get; set; }
    }

    public class Rating
    {
        [Key]
        public int RatingId { get; set; }
        public int Points { get; set; }
        [Required]
        public int UserId { get; set; }
        public User User { get; set; }
    }

    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        [Required]
        public string Name { get; set; }
    }

    public class RefreshToken
    {
        [Key]
        public int TokenId { get; set; }
        [Required]
        public string Token { get; set; }
        [Required]
        public DateTime ExpiryDate { get; set; }
        [Required]
        public int UserId { get; set; }
        public User User { get; set; }
    }

    public class CommentLike
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        public User User { get; set; }
        [Required]
        public int CommentId { get; set; }
        public Comment Comment { get; set; }
        [Required]
        public bool IsLike { get; set; }
    }
}
