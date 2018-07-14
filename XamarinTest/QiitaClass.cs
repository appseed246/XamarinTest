// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var qiita = Qiita.FromJson(jsonString);

namespace QuickType
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class QiitaClass
    {
        [JsonProperty("access_token")]
        public AccessToken AccessToken { get; set; }

        [JsonProperty("authenticated_user")]
        public AuthenticatedUser AuthenticatedUser { get; set; }

        [JsonProperty("comment")]
        public Comment Comment { get; set; }

        [JsonProperty("expanded_template")]
        public ExpandedTemplate ExpandedTemplate { get; set; }

        [JsonProperty("group")]
        public QiitaGroup Group { get; set; }

        [JsonProperty("item")]
        public Item Item { get; set; }

        [JsonProperty("like")]
        public Like Like { get; set; }

        [JsonProperty("project")]
        public Project Project { get; set; }

        [JsonProperty("reaction")]
        public EmojiReaction Reaction { get; set; }

        [JsonProperty("tag")]
        public Tag Tag { get; set; }

        [JsonProperty("tagging")]
        public Tagging Tagging { get; set; }

        [JsonProperty("team")]
        public Team Team { get; set; }

        [JsonProperty("team_invitation")]
        public InvitedMember TeamInvitation { get; set; }

        [JsonProperty("template")]
        public Template Template { get; set; }

        [JsonProperty("user")]
        public QiitaUser User { get; set; }
    }

    public partial class AccessTokenClass
    {
        [JsonProperty("client_id")]
        public string ClientId { get; set; }

        [JsonProperty("scopes")]
        public string[] Scopes { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }
    }

    public partial class AuthenticatedUserClass
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("facebook_id")]
        public string FacebookId { get; set; }

        [JsonProperty("followees_count")]
        public long FolloweesCount { get; set; }

        [JsonProperty("followers_count")]
        public long FollowersCount { get; set; }

        [JsonProperty("github_login_name")]
        public string GithubLoginName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("image_monthly_upload_limit")]
        public long ImageMonthlyUploadLimit { get; set; }

        [JsonProperty("image_monthly_upload_remaining")]
        public long ImageMonthlyUploadRemaining { get; set; }

        [JsonProperty("items_count")]
        public long ItemsCount { get; set; }

        [JsonProperty("linkedin_id")]
        public string LinkedinId { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organization")]
        public string Organization { get; set; }

        [JsonProperty("permanent_id")]
        public long PermanentId { get; set; }

        [JsonProperty("profile_image_url")]
        public string ProfileImageUrl { get; set; }

        [JsonProperty("team_only")]
        public bool TeamOnly { get; set; }

        [JsonProperty("twitter_screen_name")]
        public string TwitterScreenName { get; set; }

        [JsonProperty("website_url")]
        public string WebsiteUrl { get; set; }
    }

    public partial class CommentClass
    {
        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("rendered_body")]
        public string RenderedBody { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("user")]
        public CommentUser User { get; set; }
    }

    public partial class PurpleUser
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("facebook_id")]
        public string FacebookId { get; set; }

        [JsonProperty("followees_count")]
        public long FolloweesCount { get; set; }

        [JsonProperty("followers_count")]
        public long FollowersCount { get; set; }

        [JsonProperty("github_login_name")]
        public string GithubLoginName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("items_count")]
        public long ItemsCount { get; set; }

        [JsonProperty("linkedin_id")]
        public string LinkedinId { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organization")]
        public string Organization { get; set; }

        [JsonProperty("permanent_id")]
        public long PermanentId { get; set; }

        [JsonProperty("profile_image_url")]
        public string ProfileImageUrl { get; set; }

        [JsonProperty("twitter_screen_name")]
        public string TwitterScreenName { get; set; }

        [JsonProperty("website_url")]
        public string WebsiteUrl { get; set; }
    }

    public partial class ExpandedTemplateClass
    {
        [JsonProperty("expanded_body")]
        public string ExpandedBody { get; set; }

        [JsonProperty("expanded_tags")]
        public ExpandedTemplateExpandedTag[] ExpandedTags { get; set; }

        [JsonProperty("expanded_title")]
        public string ExpandedTitle { get; set; }
    }

    public partial class PurpleExpandedTag
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("versions", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Versions { get; set; }
    }

    public partial class PurpleGroup
    {
        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("url_name")]
        public string UrlName { get; set; }
    }

    public partial class ItemClass
    {
        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("coediting")]
        public bool Coediting { get; set; }

        [JsonProperty("comments_count")]
        public long CommentsCount { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
        public ItemGroup Group { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("likes_count")]
        public long LikesCount { get; set; }

        [JsonProperty("page_views_count")]
        public long? PageViewsCount { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("reactions_count")]
        public long ReactionsCount { get; set; }

        [JsonProperty("rendered_body")]
        public string RenderedBody { get; set; }

        [JsonProperty("tags")]
        public ItemTag[] Tags { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("user")]
        public ItemUser User { get; set; }
    }

    public partial class FluffyGroup
    {
        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("url_name")]
        public string UrlName { get; set; }
    }

    /// <summary>
    /// A list of tags
    /// </summary>
    public partial class ItemTag
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("versions", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Versions { get; set; }
    }

    public partial class FluffyUser
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("facebook_id")]
        public string FacebookId { get; set; }

        [JsonProperty("followees_count")]
        public long FolloweesCount { get; set; }

        [JsonProperty("followers_count")]
        public long FollowersCount { get; set; }

        [JsonProperty("github_login_name")]
        public string GithubLoginName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("items_count")]
        public long ItemsCount { get; set; }

        [JsonProperty("linkedin_id")]
        public string LinkedinId { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organization")]
        public string Organization { get; set; }

        [JsonProperty("permanent_id")]
        public long PermanentId { get; set; }

        [JsonProperty("profile_image_url")]
        public string ProfileImageUrl { get; set; }

        [JsonProperty("twitter_screen_name")]
        public string TwitterScreenName { get; set; }

        [JsonProperty("website_url")]
        public string WebsiteUrl { get; set; }
    }

    public partial class LikeClass
    {
        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("user")]
        public LikeUser User { get; set; }
    }

    public partial class TentacledUser
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("facebook_id")]
        public string FacebookId { get; set; }

        [JsonProperty("followees_count")]
        public long FolloweesCount { get; set; }

        [JsonProperty("followers_count")]
        public long FollowersCount { get; set; }

        [JsonProperty("github_login_name")]
        public string GithubLoginName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("items_count")]
        public long ItemsCount { get; set; }

        [JsonProperty("linkedin_id")]
        public string LinkedinId { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organization")]
        public string Organization { get; set; }

        [JsonProperty("permanent_id")]
        public long PermanentId { get; set; }

        [JsonProperty("profile_image_url")]
        public string ProfileImageUrl { get; set; }

        [JsonProperty("twitter_screen_name")]
        public string TwitterScreenName { get; set; }

        [JsonProperty("website_url")]
        public string WebsiteUrl { get; set; }
    }

    public partial class ProjectClass
    {
        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("reactions_count")]
        public long ReactionsCount { get; set; }

        [JsonProperty("rendered_body")]
        public string RenderedBody { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }
    }

    public partial class EmojiReactionClass
    {
        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("user")]
        public EmojiReactionUser User { get; set; }
    }

    public partial class StickyUser
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("facebook_id")]
        public string FacebookId { get; set; }

        [JsonProperty("followees_count")]
        public long FolloweesCount { get; set; }

        [JsonProperty("followers_count")]
        public long FollowersCount { get; set; }

        [JsonProperty("github_login_name")]
        public string GithubLoginName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("items_count")]
        public long ItemsCount { get; set; }

        [JsonProperty("linkedin_id")]
        public string LinkedinId { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organization")]
        public string Organization { get; set; }

        [JsonProperty("permanent_id")]
        public long PermanentId { get; set; }

        [JsonProperty("profile_image_url")]
        public string ProfileImageUrl { get; set; }

        [JsonProperty("twitter_screen_name")]
        public string TwitterScreenName { get; set; }

        [JsonProperty("website_url")]
        public string WebsiteUrl { get; set; }
    }

    public partial class TagClass
    {
        [JsonProperty("followers_count")]
        public long FollowersCount { get; set; }

        [JsonProperty("icon_url")]
        public string IconUrl { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("items_count")]
        public long ItemsCount { get; set; }
    }

    public partial class TaggingClass
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("versions")]
        public string[] Versions { get; set; }
    }

    public partial class TeamClass
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class InvitedMemberClass
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public partial class TemplateClass
    {
        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("expanded_body")]
        public string ExpandedBody { get; set; }

        [JsonProperty("expanded_tags")]
        public TemplateExpandedTag[] ExpandedTags { get; set; }

        [JsonProperty("expanded_title")]
        public string ExpandedTitle { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tags")]
        public TagUnion[] Tags { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public partial class FluffyExpandedTag
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("versions", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Versions { get; set; }
    }

    public partial class TagTag
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("versions", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Versions { get; set; }
    }

    public partial class IndigoUser
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("facebook_id")]
        public string FacebookId { get; set; }

        [JsonProperty("followees_count")]
        public long FolloweesCount { get; set; }

        [JsonProperty("followers_count")]
        public long FollowersCount { get; set; }

        [JsonProperty("github_login_name")]
        public string GithubLoginName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("items_count")]
        public long ItemsCount { get; set; }

        [JsonProperty("linkedin_id")]
        public string LinkedinId { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organization")]
        public string Organization { get; set; }

        [JsonProperty("permanent_id")]
        public long PermanentId { get; set; }

        [JsonProperty("profile_image_url")]
        public string ProfileImageUrl { get; set; }

        [JsonProperty("twitter_screen_name")]
        public string TwitterScreenName { get; set; }

        [JsonProperty("website_url")]
        public string WebsiteUrl { get; set; }
    }

    /// <summary>
    /// Access token for Qiita API v2
    /// </summary>
    public partial struct AccessToken
    {
        public AccessTokenClass AccessTokenClass;
        public object[] AnythingArray;
        public bool? Bool;
        public double? Double;
        public long? Integer;
        public string String;

        public bool IsNull => AnythingArray == null && Bool == null && AccessTokenClass == null && Double == null && Integer == null && String == null;
    }

    /// <summary>
    /// An user currently authenticated by a given access token. This resources has more detailed
    /// information than normal User resource.
    /// </summary>
    public partial struct AuthenticatedUser
    {
        public object[] AnythingArray;
        public AuthenticatedUserClass AuthenticatedUserClass;
        public bool? Bool;
        public double? Double;
        public long? Integer;
        public string String;

        public bool IsNull => AnythingArray == null && Bool == null && AuthenticatedUserClass == null && Double == null && Integer == null && String == null;
    }

    /// <summary>
    /// A Qiita user (a.k.a. account)
    /// </summary>
    public partial struct CommentUser
    {
        public object[] AnythingArray;
        public bool? Bool;
        public double? Double;
        public long? Integer;
        public PurpleUser PurpleUser;
        public string String;

        public bool IsNull => AnythingArray == null && Bool == null && PurpleUser == null && Double == null && Integer == null && String == null;
    }

    /// <summary>
    /// A comment posted on an item or a project. A comment on a project is available only on
    /// Qiita:Team.
    /// </summary>
    public partial struct Comment
    {
        public object[] AnythingArray;
        public bool? Bool;
        public CommentClass CommentClass;
        public double? Double;
        public long? Integer;
        public string String;

        public bool IsNull => AnythingArray == null && Bool == null && CommentClass == null && Double == null && Integer == null && String == null;
    }

    /// <summary>
    /// A list of tags where variables are expanded
    /// </summary>
    public partial struct ExpandedTemplateExpandedTag
    {
        public object[] AnythingArray;
        public bool? Bool;
        public double? Double;
        public long? Integer;
        public PurpleExpandedTag PurpleExpandedTag;
        public string String;

        public bool IsNull => AnythingArray == null && Bool == null && PurpleExpandedTag == null && Double == null && Integer == null && String == null;
    }

    /// <summary>
    /// You can preview the expanded result of a given template. This is available only on
    /// Qiita:Team.
    /// </summary>
    public partial struct ExpandedTemplate
    {
        public object[] AnythingArray;
        public bool? Bool;
        public double? Double;
        public ExpandedTemplateClass ExpandedTemplateClass;
        public long? Integer;
        public string String;

        public bool IsNull => AnythingArray == null && Bool == null && ExpandedTemplateClass == null && Double == null && Integer == null && String == null;
    }

    /// <summary>
    /// Represents a group on Qiita:Team
    /// </summary>
    public partial struct QiitaGroup
    {
        public object[] AnythingArray;
        public bool? Bool;
        public double? Double;
        public long? Integer;
        public PurpleGroup PurpleGroup;
        public string String;

        public bool IsNull => AnythingArray == null && Bool == null && PurpleGroup == null && Double == null && Integer == null && String == null;
    }

    /// <summary>
    /// Represents a group on Qiita:Team
    /// </summary>
    public partial struct ItemGroup
    {
        public object[] AnythingArray;
        public bool? Bool;
        public double? Double;
        public FluffyGroup FluffyGroup;
        public long? Integer;
        public string String;

        public bool IsNull => AnythingArray == null && Bool == null && FluffyGroup == null && Double == null && Integer == null && String == null;
    }

    /// <summary>
    /// A Qiita user (a.k.a. account)
    /// </summary>
    public partial struct ItemUser
    {
        public object[] AnythingArray;
        public bool? Bool;
        public double? Double;
        public FluffyUser FluffyUser;
        public long? Integer;
        public string String;

        public bool IsNull => AnythingArray == null && Bool == null && FluffyUser == null && Double == null && Integer == null && String == null;
    }

    /// <summary>
    /// Represents an item posted from a user
    /// </summary>
    public partial struct Item
    {
        public object[] AnythingArray;
        public bool? Bool;
        public double? Double;
        public long? Integer;
        public ItemClass ItemClass;
        public string String;

        public bool IsNull => AnythingArray == null && Bool == null && ItemClass == null && Double == null && Integer == null && String == null;
    }

    /// <summary>
    /// A Qiita user (a.k.a. account)
    /// </summary>
    public partial struct LikeUser
    {
        public object[] AnythingArray;
        public bool? Bool;
        public double? Double;
        public long? Integer;
        public string String;
        public TentacledUser TentacledUser;

        public bool IsNull => AnythingArray == null && Bool == null && TentacledUser == null && Double == null && Integer == null && String == null;
    }

    /// <summary>
    /// <strong>The Like API on Qiita:Team has been deprecated since Oct 24 2017. Please use the
    /// Emoji reaction API instead.</strong> Represents a like to an item.
    /// </summary>
    public partial struct Like
    {
        public object[] AnythingArray;
        public bool? Bool;
        public double? Double;
        public long? Integer;
        public LikeClass LikeClass;
        public string String;

        public bool IsNull => AnythingArray == null && Bool == null && LikeClass == null && Double == null && Integer == null && String == null;
    }

    /// <summary>
    /// Represents a project on Qiita:Team (only available on Qiita:Team).
    /// </summary>
    public partial struct Project
    {
        public object[] AnythingArray;
        public bool? Bool;
        public double? Double;
        public long? Integer;
        public ProjectClass ProjectClass;
        public string String;

        public bool IsNull => AnythingArray == null && Bool == null && ProjectClass == null && Double == null && Integer == null && String == null;
    }

    /// <summary>
    /// A Qiita user (a.k.a. account)
    /// </summary>
    public partial struct EmojiReactionUser
    {
        public object[] AnythingArray;
        public bool? Bool;
        public double? Double;
        public long? Integer;
        public StickyUser StickyUser;
        public string String;

        public bool IsNull => AnythingArray == null && Bool == null && StickyUser == null && Double == null && Integer == null && String == null;
    }

    /// <summary>
    /// An emoji reaction on Qiita:Team (only availabble on Qiita:Team).
    /// </summary>
    public partial struct EmojiReaction
    {
        public object[] AnythingArray;
        public bool? Bool;
        public double? Double;
        public EmojiReactionClass EmojiReactionClass;
        public long? Integer;
        public string String;

        public bool IsNull => AnythingArray == null && Bool == null && EmojiReactionClass == null && Double == null && Integer == null && String == null;
    }

    /// <summary>
    /// A tag attached to an item
    /// </summary>
    public partial struct Tag
    {
        public object[] AnythingArray;
        public bool? Bool;
        public double? Double;
        public long? Integer;
        public string String;
        public TagClass TagClass;

        public bool IsNull => AnythingArray == null && Bool == null && TagClass == null && Double == null && Integer == null && String == null;
    }

    /// <summary>
    /// Represents an association between an item and a tag.
    /// </summary>
    public partial struct Tagging
    {
        public object[] AnythingArray;
        public bool? Bool;
        public double? Double;
        public long? Integer;
        public string String;
        public TaggingClass TaggingClass;

        public bool IsNull => AnythingArray == null && Bool == null && TaggingClass == null && Double == null && Integer == null && String == null;
    }

    /// <summary>
    /// Represents a team on Qiita:Team (only available on Qiita:Team).
    /// </summary>
    public partial struct Team
    {
        public object[] AnythingArray;
        public bool? Bool;
        public double? Double;
        public long? Integer;
        public string String;
        public TeamClass TeamClass;

        public bool IsNull => AnythingArray == null && Bool == null && TeamClass == null && Double == null && Integer == null && String == null;
    }

    /// <summary>
    /// Represents members who are invited to on Qiita:Team (only available on Qiita:Team).
    /// </summary>
    public partial struct InvitedMember
    {
        public object[] AnythingArray;
        public bool? Bool;
        public double? Double;
        public long? Integer;
        public InvitedMemberClass InvitedMemberClass;
        public string String;

        public bool IsNull => AnythingArray == null && Bool == null && InvitedMemberClass == null && Double == null && Integer == null && String == null;
    }

    /// <summary>
    /// A list of tags where variables are expanded
    /// </summary>
    public partial struct TemplateExpandedTag
    {
        public object[] AnythingArray;
        public bool? Bool;
        public double? Double;
        public FluffyExpandedTag FluffyExpandedTag;
        public long? Integer;
        public string String;

        public bool IsNull => AnythingArray == null && Bool == null && FluffyExpandedTag == null && Double == null && Integer == null && String == null;
    }

    /// <summary>
    /// A list of tags
    /// </summary>
    public partial struct TagUnion
    {
        public object[] AnythingArray;
        public bool? Bool;
        public double? Double;
        public long? Integer;
        public string String;
        public TagTag TagTag;

        public bool IsNull => AnythingArray == null && Bool == null && TagTag == null && Double == null && Integer == null && String == null;
    }

    /// <summary>
    /// Represents a template for generating an item boilerplate (only available on Qiita:Team).
    /// </summary>
    public partial struct Template
    {
        public object[] AnythingArray;
        public bool? Bool;
        public double? Double;
        public long? Integer;
        public string String;
        public TemplateClass TemplateClass;

        public bool IsNull => AnythingArray == null && Bool == null && TemplateClass == null && Double == null && Integer == null && String == null;
    }

    /// <summary>
    /// A Qiita user (a.k.a. account)
    /// </summary>
    public partial struct QiitaUser
    {
        public object[] AnythingArray;
        public bool? Bool;
        public double? Double;
        public IndigoUser IndigoUser;
        public long? Integer;
        public string String;

        public bool IsNull => AnythingArray == null && Bool == null && IndigoUser == null && Double == null && Integer == null && String == null;
    }

    /// <summary>
    /// In this schema file, we represents the public interface of Qiita API v2 in JSON Hyper
    /// Schema draft v4.
    /// </summary>
    public partial struct QiitaUnion
    {
        public object[] AnythingArray;
        public bool? Bool;
        public double? Double;
        public long? Integer;
        public QiitaClass QiitaClass;
        public string String;

        public bool IsNull => AnythingArray == null && Bool == null && QiitaClass == null && Double == null && Integer == null && String == null;
    }

    public class Qiita
    {
        public static object FromJson(string json) => JsonConvert.DeserializeObject<object>(json, QuickType.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this object self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                QiitaUnionConverter.Singleton,
                AccessTokenConverter.Singleton,
                AuthenticatedUserConverter.Singleton,
                CommentConverter.Singleton,
                CommentUserConverter.Singleton,
                ExpandedTemplateConverter.Singleton,
                ExpandedTemplateExpandedTagConverter.Singleton,
                QiitaGroupConverter.Singleton,
                ItemConverter.Singleton,
                ItemGroupConverter.Singleton,
                ItemUserConverter.Singleton,
                LikeConverter.Singleton,
                LikeUserConverter.Singleton,
                ProjectConverter.Singleton,
                EmojiReactionConverter.Singleton,
                EmojiReactionUserConverter.Singleton,
                TagConverter.Singleton,
                TaggingConverter.Singleton,
                TeamConverter.Singleton,
                InvitedMemberConverter.Singleton,
                TemplateConverter.Singleton,
                TemplateExpandedTagConverter.Singleton,
                TagUnionConverter.Singleton,
                QiitaUserConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class QiitaUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(QiitaUnion) || t == typeof(QiitaUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new QiitaUnion { };
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new QiitaUnion { Integer = integerValue };
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new QiitaUnion { Double = doubleValue };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new QiitaUnion { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new QiitaUnion { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<QiitaClass>(reader);
                    return new QiitaUnion { QiitaClass = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<object[]>(reader);
                    return new QiitaUnion { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type QiitaUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (QiitaUnion)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.QiitaClass != null)
            {
                serializer.Serialize(writer, value.QiitaClass);
                return;
            }
            throw new Exception("Cannot marshal type QiitaUnion");
        }

        public static readonly QiitaUnionConverter Singleton = new QiitaUnionConverter();
    }

    internal class AccessTokenConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AccessToken) || t == typeof(AccessToken?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new AccessToken { };
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new AccessToken { Integer = integerValue };
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new AccessToken { Double = doubleValue };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new AccessToken { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new AccessToken { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<AccessTokenClass>(reader);
                    return new AccessToken { AccessTokenClass = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<object[]>(reader);
                    return new AccessToken { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type AccessToken");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (AccessToken)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.AccessTokenClass != null)
            {
                serializer.Serialize(writer, value.AccessTokenClass);
                return;
            }
            throw new Exception("Cannot marshal type AccessToken");
        }

        public static readonly AccessTokenConverter Singleton = new AccessTokenConverter();
    }

    internal class AuthenticatedUserConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AuthenticatedUser) || t == typeof(AuthenticatedUser?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new AuthenticatedUser { };
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new AuthenticatedUser { Integer = integerValue };
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new AuthenticatedUser { Double = doubleValue };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new AuthenticatedUser { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new AuthenticatedUser { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<AuthenticatedUserClass>(reader);
                    return new AuthenticatedUser { AuthenticatedUserClass = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<object[]>(reader);
                    return new AuthenticatedUser { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type AuthenticatedUser");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (AuthenticatedUser)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.AuthenticatedUserClass != null)
            {
                serializer.Serialize(writer, value.AuthenticatedUserClass);
                return;
            }
            throw new Exception("Cannot marshal type AuthenticatedUser");
        }

        public static readonly AuthenticatedUserConverter Singleton = new AuthenticatedUserConverter();
    }

    internal class CommentConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Comment) || t == typeof(Comment?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new Comment { };
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new Comment { Integer = integerValue };
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new Comment { Double = doubleValue };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new Comment { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new Comment { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<CommentClass>(reader);
                    return new Comment { CommentClass = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<object[]>(reader);
                    return new Comment { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type Comment");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Comment)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.CommentClass != null)
            {
                serializer.Serialize(writer, value.CommentClass);
                return;
            }
            throw new Exception("Cannot marshal type Comment");
        }

        public static readonly CommentConverter Singleton = new CommentConverter();
    }

    internal class CommentUserConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CommentUser) || t == typeof(CommentUser?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new CommentUser { };
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new CommentUser { Integer = integerValue };
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new CommentUser { Double = doubleValue };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new CommentUser { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new CommentUser { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<PurpleUser>(reader);
                    return new CommentUser { PurpleUser = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<object[]>(reader);
                    return new CommentUser { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type CommentUser");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (CommentUser)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.PurpleUser != null)
            {
                serializer.Serialize(writer, value.PurpleUser);
                return;
            }
            throw new Exception("Cannot marshal type CommentUser");
        }

        public static readonly CommentUserConverter Singleton = new CommentUserConverter();
    }

    internal class ExpandedTemplateConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ExpandedTemplate) || t == typeof(ExpandedTemplate?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new ExpandedTemplate { };
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new ExpandedTemplate { Integer = integerValue };
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new ExpandedTemplate { Double = doubleValue };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new ExpandedTemplate { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new ExpandedTemplate { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ExpandedTemplateClass>(reader);
                    return new ExpandedTemplate { ExpandedTemplateClass = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<object[]>(reader);
                    return new ExpandedTemplate { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type ExpandedTemplate");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ExpandedTemplate)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.ExpandedTemplateClass != null)
            {
                serializer.Serialize(writer, value.ExpandedTemplateClass);
                return;
            }
            throw new Exception("Cannot marshal type ExpandedTemplate");
        }

        public static readonly ExpandedTemplateConverter Singleton = new ExpandedTemplateConverter();
    }

    internal class ExpandedTemplateExpandedTagConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ExpandedTemplateExpandedTag) || t == typeof(ExpandedTemplateExpandedTag?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new ExpandedTemplateExpandedTag { };
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new ExpandedTemplateExpandedTag { Integer = integerValue };
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new ExpandedTemplateExpandedTag { Double = doubleValue };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new ExpandedTemplateExpandedTag { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new ExpandedTemplateExpandedTag { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<PurpleExpandedTag>(reader);
                    return new ExpandedTemplateExpandedTag { PurpleExpandedTag = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<object[]>(reader);
                    return new ExpandedTemplateExpandedTag { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type ExpandedTemplateExpandedTag");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ExpandedTemplateExpandedTag)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.PurpleExpandedTag != null)
            {
                serializer.Serialize(writer, value.PurpleExpandedTag);
                return;
            }
            throw new Exception("Cannot marshal type ExpandedTemplateExpandedTag");
        }

        public static readonly ExpandedTemplateExpandedTagConverter Singleton = new ExpandedTemplateExpandedTagConverter();
    }

    internal class QiitaGroupConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(QiitaGroup) || t == typeof(QiitaGroup?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new QiitaGroup { };
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new QiitaGroup { Integer = integerValue };
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new QiitaGroup { Double = doubleValue };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new QiitaGroup { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new QiitaGroup { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<PurpleGroup>(reader);
                    return new QiitaGroup { PurpleGroup = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<object[]>(reader);
                    return new QiitaGroup { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type QiitaGroup");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (QiitaGroup)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.PurpleGroup != null)
            {
                serializer.Serialize(writer, value.PurpleGroup);
                return;
            }
            throw new Exception("Cannot marshal type QiitaGroup");
        }

        public static readonly QiitaGroupConverter Singleton = new QiitaGroupConverter();
    }

    internal class ItemConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Item) || t == typeof(Item?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new Item { };
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new Item { Integer = integerValue };
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new Item { Double = doubleValue };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new Item { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new Item { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ItemClass>(reader);
                    return new Item { ItemClass = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<object[]>(reader);
                    return new Item { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type Item");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Item)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.ItemClass != null)
            {
                serializer.Serialize(writer, value.ItemClass);
                return;
            }
            throw new Exception("Cannot marshal type Item");
        }

        public static readonly ItemConverter Singleton = new ItemConverter();
    }

    internal class ItemGroupConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ItemGroup) || t == typeof(ItemGroup?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new ItemGroup { };
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new ItemGroup { Integer = integerValue };
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new ItemGroup { Double = doubleValue };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new ItemGroup { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new ItemGroup { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<FluffyGroup>(reader);
                    return new ItemGroup { FluffyGroup = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<object[]>(reader);
                    return new ItemGroup { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type ItemGroup");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ItemGroup)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.FluffyGroup != null)
            {
                serializer.Serialize(writer, value.FluffyGroup);
                return;
            }
            throw new Exception("Cannot marshal type ItemGroup");
        }

        public static readonly ItemGroupConverter Singleton = new ItemGroupConverter();
    }

    internal class ItemUserConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ItemUser) || t == typeof(ItemUser?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new ItemUser { };
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new ItemUser { Integer = integerValue };
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new ItemUser { Double = doubleValue };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new ItemUser { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new ItemUser { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<FluffyUser>(reader);
                    return new ItemUser { FluffyUser = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<object[]>(reader);
                    return new ItemUser { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type ItemUser");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ItemUser)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.FluffyUser != null)
            {
                serializer.Serialize(writer, value.FluffyUser);
                return;
            }
            throw new Exception("Cannot marshal type ItemUser");
        }

        public static readonly ItemUserConverter Singleton = new ItemUserConverter();
    }

    internal class LikeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Like) || t == typeof(Like?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new Like { };
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new Like { Integer = integerValue };
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new Like { Double = doubleValue };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new Like { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new Like { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<LikeClass>(reader);
                    return new Like { LikeClass = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<object[]>(reader);
                    return new Like { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type Like");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Like)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.LikeClass != null)
            {
                serializer.Serialize(writer, value.LikeClass);
                return;
            }
            throw new Exception("Cannot marshal type Like");
        }

        public static readonly LikeConverter Singleton = new LikeConverter();
    }

    internal class LikeUserConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LikeUser) || t == typeof(LikeUser?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new LikeUser { };
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new LikeUser { Integer = integerValue };
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new LikeUser { Double = doubleValue };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new LikeUser { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new LikeUser { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<TentacledUser>(reader);
                    return new LikeUser { TentacledUser = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<object[]>(reader);
                    return new LikeUser { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type LikeUser");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (LikeUser)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.TentacledUser != null)
            {
                serializer.Serialize(writer, value.TentacledUser);
                return;
            }
            throw new Exception("Cannot marshal type LikeUser");
        }

        public static readonly LikeUserConverter Singleton = new LikeUserConverter();
    }

    internal class ProjectConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Project) || t == typeof(Project?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new Project { };
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new Project { Integer = integerValue };
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new Project { Double = doubleValue };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new Project { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new Project { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ProjectClass>(reader);
                    return new Project { ProjectClass = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<object[]>(reader);
                    return new Project { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type Project");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Project)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.ProjectClass != null)
            {
                serializer.Serialize(writer, value.ProjectClass);
                return;
            }
            throw new Exception("Cannot marshal type Project");
        }

        public static readonly ProjectConverter Singleton = new ProjectConverter();
    }

    internal class EmojiReactionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(EmojiReaction) || t == typeof(EmojiReaction?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new EmojiReaction { };
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new EmojiReaction { Integer = integerValue };
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new EmojiReaction { Double = doubleValue };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new EmojiReaction { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new EmojiReaction { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<EmojiReactionClass>(reader);
                    return new EmojiReaction { EmojiReactionClass = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<object[]>(reader);
                    return new EmojiReaction { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type EmojiReaction");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (EmojiReaction)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.EmojiReactionClass != null)
            {
                serializer.Serialize(writer, value.EmojiReactionClass);
                return;
            }
            throw new Exception("Cannot marshal type EmojiReaction");
        }

        public static readonly EmojiReactionConverter Singleton = new EmojiReactionConverter();
    }

    internal class EmojiReactionUserConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(EmojiReactionUser) || t == typeof(EmojiReactionUser?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new EmojiReactionUser { };
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new EmojiReactionUser { Integer = integerValue };
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new EmojiReactionUser { Double = doubleValue };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new EmojiReactionUser { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new EmojiReactionUser { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<StickyUser>(reader);
                    return new EmojiReactionUser { StickyUser = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<object[]>(reader);
                    return new EmojiReactionUser { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type EmojiReactionUser");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (EmojiReactionUser)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.StickyUser != null)
            {
                serializer.Serialize(writer, value.StickyUser);
                return;
            }
            throw new Exception("Cannot marshal type EmojiReactionUser");
        }

        public static readonly EmojiReactionUserConverter Singleton = new EmojiReactionUserConverter();
    }

    internal class TagConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Tag) || t == typeof(Tag?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new Tag { };
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new Tag { Integer = integerValue };
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new Tag { Double = doubleValue };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new Tag { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new Tag { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<TagClass>(reader);
                    return new Tag { TagClass = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<object[]>(reader);
                    return new Tag { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type Tag");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Tag)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.TagClass != null)
            {
                serializer.Serialize(writer, value.TagClass);
                return;
            }
            throw new Exception("Cannot marshal type Tag");
        }

        public static readonly TagConverter Singleton = new TagConverter();
    }

    internal class TaggingConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Tagging) || t == typeof(Tagging?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new Tagging { };
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new Tagging { Integer = integerValue };
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new Tagging { Double = doubleValue };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new Tagging { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new Tagging { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<TaggingClass>(reader);
                    return new Tagging { TaggingClass = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<object[]>(reader);
                    return new Tagging { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type Tagging");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Tagging)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.TaggingClass != null)
            {
                serializer.Serialize(writer, value.TaggingClass);
                return;
            }
            throw new Exception("Cannot marshal type Tagging");
        }

        public static readonly TaggingConverter Singleton = new TaggingConverter();
    }

    internal class TeamConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Team) || t == typeof(Team?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new Team { };
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new Team { Integer = integerValue };
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new Team { Double = doubleValue };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new Team { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new Team { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<TeamClass>(reader);
                    return new Team { TeamClass = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<object[]>(reader);
                    return new Team { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type Team");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Team)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.TeamClass != null)
            {
                serializer.Serialize(writer, value.TeamClass);
                return;
            }
            throw new Exception("Cannot marshal type Team");
        }

        public static readonly TeamConverter Singleton = new TeamConverter();
    }

    internal class InvitedMemberConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(InvitedMember) || t == typeof(InvitedMember?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new InvitedMember { };
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new InvitedMember { Integer = integerValue };
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new InvitedMember { Double = doubleValue };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new InvitedMember { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new InvitedMember { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<InvitedMemberClass>(reader);
                    return new InvitedMember { InvitedMemberClass = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<object[]>(reader);
                    return new InvitedMember { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type InvitedMember");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (InvitedMember)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.InvitedMemberClass != null)
            {
                serializer.Serialize(writer, value.InvitedMemberClass);
                return;
            }
            throw new Exception("Cannot marshal type InvitedMember");
        }

        public static readonly InvitedMemberConverter Singleton = new InvitedMemberConverter();
    }

    internal class TemplateConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Template) || t == typeof(Template?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new Template { };
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new Template { Integer = integerValue };
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new Template { Double = doubleValue };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new Template { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new Template { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<TemplateClass>(reader);
                    return new Template { TemplateClass = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<object[]>(reader);
                    return new Template { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type Template");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Template)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.TemplateClass != null)
            {
                serializer.Serialize(writer, value.TemplateClass);
                return;
            }
            throw new Exception("Cannot marshal type Template");
        }

        public static readonly TemplateConverter Singleton = new TemplateConverter();
    }

    internal class TemplateExpandedTagConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TemplateExpandedTag) || t == typeof(TemplateExpandedTag?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new TemplateExpandedTag { };
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new TemplateExpandedTag { Integer = integerValue };
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new TemplateExpandedTag { Double = doubleValue };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new TemplateExpandedTag { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new TemplateExpandedTag { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<FluffyExpandedTag>(reader);
                    return new TemplateExpandedTag { FluffyExpandedTag = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<object[]>(reader);
                    return new TemplateExpandedTag { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type TemplateExpandedTag");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (TemplateExpandedTag)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.FluffyExpandedTag != null)
            {
                serializer.Serialize(writer, value.FluffyExpandedTag);
                return;
            }
            throw new Exception("Cannot marshal type TemplateExpandedTag");
        }

        public static readonly TemplateExpandedTagConverter Singleton = new TemplateExpandedTagConverter();
    }

    internal class TagUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TagUnion) || t == typeof(TagUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new TagUnion { };
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new TagUnion { Integer = integerValue };
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new TagUnion { Double = doubleValue };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new TagUnion { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new TagUnion { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<TagTag>(reader);
                    return new TagUnion { TagTag = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<object[]>(reader);
                    return new TagUnion { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type TagUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (TagUnion)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.TagTag != null)
            {
                serializer.Serialize(writer, value.TagTag);
                return;
            }
            throw new Exception("Cannot marshal type TagUnion");
        }

        public static readonly TagUnionConverter Singleton = new TagUnionConverter();
    }

    internal class QiitaUserConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(QiitaUser) || t == typeof(QiitaUser?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new QiitaUser { };
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new QiitaUser { Integer = integerValue };
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new QiitaUser { Double = doubleValue };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new QiitaUser { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new QiitaUser { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<IndigoUser>(reader);
                    return new QiitaUser { IndigoUser = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<object[]>(reader);
                    return new QiitaUser { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type QiitaUser");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (QiitaUser)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.IndigoUser != null)
            {
                serializer.Serialize(writer, value.IndigoUser);
                return;
            }
            throw new Exception("Cannot marshal type QiitaUser");
        }

        public static readonly QiitaUserConverter Singleton = new QiitaUserConverter();
    }
}
