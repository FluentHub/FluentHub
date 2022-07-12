﻿namespace FluentHub.Octokit.Queries.Repositories
{
    public class DiffQueries
    {
        public async Task<OctokitOriginal.GitHubCommit> GetAllAsync(string owner, string name, string refs)
        {
            var commit = await App.Client.Repository.Commit.Get(owner, name, refs);

            return commit;

            //CommitDetails item = new()
            //{
            //    CommitMessage = commit.Commit.Message,
            //    CommitMessageHeadline = commit.Commit.Message.Split('\n')[0],
            //    Oid = commit.Sha,
            //    AbbreviatedOid = commit.Sha.Substring(0, 7),
            //    ParentOid = commit.Parents[0].Sha,
            //    AbbreviatedParentOid = commit.Parents[0].Sha.Substring(0, 7),
            //    TotalAdditions = commit.Stats.Additions,
            //    TotalDeletions = commit.Stats.Deletions,
            //    TotalChangedFileCount = commit.Stats.Total,
            //};

            //foreach (var file in commit.Files)
            //{
            //    ChangedFile changedFile = new()
            //    {
            //        TotalLineCount = file.Changes,
            //        LineAdditions = file.Additions,
            //        LineDeletions = file.Deletions,
            //        Patch = file.Patch,
            //        ChangeType = file.Status,
            //        FileName = file.Filename,
            //        PreviousFileName = file.PreviousFileName,
            //    };

            //    item.ChangedFiles.Add(changedFile);
            //}

            //return item;
        }

        public async Task<List<OctokitOriginal.PullRequestFile>> GetAllAsync(string owner, string name, int number)
        {
            var files = await App.Client.Repository.PullRequest.Files(owner, name, number);

            //List<ChangedFile> changedFiles = new();
            //foreach (var file in files)
            //{
            //    ChangedFile changedFile = new()
            //    {
            //        TotalLineCount = file.Changes,
            //        LineAdditions = file.Additions,
            //        LineDeletions = file.Deletions,
            //        Patch = file.Patch,
            //        ChangeType = file.Status,
            //        FileName = file.FileName,
            //        PreviousFileName = file.PreviousFileName,
            //    };

            //    changedFiles.Add(changedFile);
            //}

            return files.ToList();
        }
    }
}
