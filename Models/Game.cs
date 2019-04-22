using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.Serialization;

namespace Lincoln.Models
{
  [DataContract]
  public class Game
  {
    [DataMember(Name = "ID")]
    public int Id { get; set; }
    [DataMember(Name = "Name")]
    public string Name { get; set; }
    [DataMember(Name = "Slug")]
    public string Slug { get; set; }
    [DataMember(Name = "DateModified")]
    public DateTimeOffset DateModified { get; set; }
    [DataMember(Name = "CategorySections")]
    public IEnumerable<CategorySection> CategorySections { get; set; }
    [DataMember(Name = "MaxFreeStorage")]
    public int MaxFreeStorage { get; set; }
    [DataMember(Name = "MaxPremiumStorage")]
    public int MaxPremiumStorage { get; set; }
    [DataMember(Name = "MaxFileSize")]
    public int MaxFileSize { get; set; }
    [DataMember(Name = "AddOnSettingsFolderFilter")]
    public string AddOnSettingsFolderFilter { get; set; }
    [DataMember(Name = "AddOnSettingsStartingFolder")]
    public string AddOnSettingsStartingFolder { get; set; }
    [DataMember(Name = "AddOnSettingsFileFilter")]
    public string AddOnSettingsFileFilter { get; set; }
    [DataMember(Name = "AddOnSettingsFileRemovalFilter")]
    public string AddOnSettingsFileRemovalFilter { get; set; }
    [DataMember(Name = "SupportsAddons")]
    public bool SupportsAddons { get; set; }
    [DataMember(Name = "SupportsVoice")]
    public bool SupportsVoice { get; set; }
    [DataMember(Name = "Order")]
    public int Order { get; set; }
    [DataMember(Name = "SupportsNotifications")]
    public bool SupportsNotifications { get; set; }
    [DataMember(Name = "BundleAssets")]
    public bool BundleAssets { get; set; }
    [DataMember(Name = "ProfilerAddOnId")]
    public int ProfilerAddOnId { get; set; }
    [DataMember(Name = "TwitchGameId")]
    public int TwitchGameId { get; set; }

    public string Icon
    {
      get
      {
        return $"https://clientupdate-v6.cursecdn.com/GameAssets/{this.Id}/Icon64.png";
      }
    }

    public string Boxart
    {
      get
      {
        return $"https://twitch-gds-boxart-aws.s3-us-west-2.amazonaws.com/{WebUtility.UrlEncode(this.Name)}.jpg";
      }
    }

    [DataContract]
    public class CategorySection
    {
      [DataMember(Name = "ID")]
      public int Id { get; set; }
      [DataMember(Name = "Name")]
      public string Name { get; set; }
    }

    [DataContract(Name = "FileParsingRules")]
    public class FileParsingRules
    {
      [DataMember(Name = "CommentStripPattern")]
      public string CommentStripPattern { get; set; }
      [DataMember(Name = "FileExtension")]
      public string FileExtension { get; set; }
      [DataMember(Name = "InclusionPattern")]
      public string InclusionPattern { get; set; }
    }
    [DataContract(Name = "GameDetectionHints")]
    public class GameDetectionHints
    {
      [DataMember(Name = "ID")]
      public int ID { get; set; }
      [DataMember(Name = "HintType")]
      public int HintType { get; set; }
      [DataMember(Name = "HintPath")]
      public string HintPath { get; set; }
      [DataMember(Name = "HintKey")]
      public string HintKey { get; set; }
      [DataMember(Name = "HintOptions")]
      public int HintOptions { get; set; }
    }
    [DataContract(Name = "GameFiles")]
    public class GameFiles
    {
      [DataMember(Name = "Id")]
      public int Id { get; set; }
      [DataMember(Name = "GameId")]
      public int GameId { get; set; }
      [DataMember(Name = "IsRequired")]
      public bool IsRequired { get; set; }
      [DataMember(Name = "FileName")]
      public string FileName { get; set; }
      [DataMember(Name = "FileType")]
      public int FileType { get; set; }
      [DataMember(Name = "PlatformType")]
      public int PlatformType { get; set; }
    }

  }
}