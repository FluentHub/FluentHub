﻿using FluentHub.OctokitEx.Models;
using Octokit.GraphQL;
using Octokit.GraphQL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentHub.OctokitEx.Queries.Repository
{
    public class PullRequestQueries
    {
        public PullRequestQueries() => new App();

        public async Task<List<PullOverviewItem>> GetOverviewAll(string name, string owner)
        {
            IssueOrder order = new() { Direction = OrderDirection.Desc, Field = IssueOrderField.CreatedAt};

            #region queries
            var query = new Query()
                .Repository(name, owner)
                .PullRequests(first: 30, orderBy: order)
                .Nodes
                .Select(x => new
                {
                    x.Closed,
                    x.Merged,
                    x.IsDraft,
                    Labels = x.Labels(10, null, null, null, null).Nodes.Select(y => new
                    {
                        y.Color,
                        y.Name,
                    }).ToList(),
                    x.Number,
                    x.Title,
                    x.UpdatedAt,
                })
                .Compile();
            #endregion

            var response = await App.Connection.Run(query);

            List<PullOverviewItem> items = new();

            foreach (var res in response)
            {
                PullOverviewItem item = new();
                item.Labels = new();

                item.IsClosed = res.Closed;
                item.IsMerged = res.Merged;
                item.IsDraft = res.IsDraft;

                foreach (var label in res.Labels)
                {
                    LabelOverviewItem labels = new();
                    labels.Color = label.Color;
                    labels.Name = label.Name;

                    item.Labels.Add(labels);
                }

                item.Number = res.Number;
                item.Title = res.Title;
                item.UpdatedAt = res.UpdatedAt;

                item.Name = name;
                item.Owner = owner;

                items.Add(item);
            }

            return items;
        }
    }
}