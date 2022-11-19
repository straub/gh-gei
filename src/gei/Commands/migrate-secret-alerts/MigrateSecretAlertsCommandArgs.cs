﻿namespace OctoshiftCLI.GithubEnterpriseImporter.Commands;

public class MigrateSecretAlertsCommandArgs : CommandArgs
{
    public string SourceOrg { get; set; }
    public string SourceRepo { get; set; }
    public string TargetOrg { get; set; }
    public string TargetRepo { get; set; }
    public string TargetApiUrl { get; set; }
    public string GhesApiUrl { get; set; }
    public bool NoSslVerify { get; set; }
    public bool DryRun { get; set; }
    [Secret]
    public string GithubSourcePat { get; set; }
    [Secret]
    public string GithubTargetPat { get; set; }
}
