﻿namespace Funding.Services.Models.ProjectViewModels
{
    using Funding.Common.Constants;
    using System.Collections.Generic;

    public class MyProjectsListingViewModel
    {
        private string previous;
        private string next;

        public MyProjectsListingViewModel()
        {
            string previous = Page == 1 ? ProjectConst.Disabled : string.Empty;
            string next = Page == NumberOfPages ? ProjectConst.Disabled : string.Empty;

            this.previous = previous;
            this.next = next;
        }

        public List<MyProjects> Projects { get; set; }

        public int Page { get; set; }

        public int NumberOfPages { get; set; }

        public string Previous
        {
            get
            {
                return this.previous;
            }
            set
            {
                this.previous = value;
            }
        }

        public string Next
        {
            get
            {
                return this.next;
            }
            set
            {
                this.next = value;
            }
        }
    }
}