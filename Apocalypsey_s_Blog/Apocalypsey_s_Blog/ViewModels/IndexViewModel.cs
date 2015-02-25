using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Apocalypsey_s_Blog.ViewModels
{
    public class IndexViewModel
    {


        public int ArticleCount { get; set; }
        public int NoteCount { get; set; }
        public List<ArticleViewModel> Article;
    }
}