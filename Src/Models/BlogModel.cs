﻿using System;

namespace DesignWeb_Project.Models
{
    public class BlogModel
    {
        public string title_blog { get; set; }

        public int blog_news_chosse { get; set; }

        public bool on_new_video { get; set; }

        public bool News_hot { get; set; }

        public int BlogID { get; set; }

        public int ArticleID { get; set; }

        public string BlogName { get; set; }

        public string ArticleName { get; set; }

        public bool Status { get; set; }

        public string Content { get; set; }

        public DateTime? CreatedAt { get; set; }

        public string Author { get; set; }

        public string Images { get; set; }

        public string Alias_Blog { get; set; }

        public string Alias_Article { get; set; }

        public string DescriptShort { get; set; }

        public string MetaTitle { get; set; }

        public string MetaKeyword { get; set; }

        public string MetaDescription { get; set; }

        public string MetaTitle_ar { get; set; }

        public string MetaKeyword_ar { get; set; }

        public string MetaDescription_ar { get; set; }
    }
}