﻿using System.ComponentModel.DataAnnotations;

namespace OkBlog.ViewModels
{
    public class CommentViewModel
    {
        [Required]
        public int MainCommentId { get; set; }
        [Required]
        public string Message { get; set; }
        [Required]
        public int PostId { get; set; }
    }
}
