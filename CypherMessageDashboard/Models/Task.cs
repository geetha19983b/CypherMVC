
using CypherMessageDashboard.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CypherMessageDashboard.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? DueDate { get; set; }
        public int AssignedToId { get; set; }
        public int CategoryId { get; set; }
        public int AssociatedMessageId { get; set; }
        public DateTime? Created { get; set; }
        public string Notes { get; set; }
        public bool Completed { get; set; }

        //Navigation Properties
        public virtual Admin AssignedTo { get; set; }
        public virtual Message AssociatedMessage { get; set; }
        public virtual Category Category { get; set; }
    }
    //[Bind(Exclude = "AssignedTo, AssociatedMessage, Category")]
    //public class Task : IValidatableObject
    //{
    //    public int Id { get; set; }
    //    [Required]
    //    public string Title { get; set; }
    //    [Required]
    //    public string Description { get; set; }
    //    [Required]
    //   [DueDate(ErrorMessage = "Date must be in the future")]
    //    public DateTime? DueDate { get; set; }
    //    [Required]
    //    public int AssignedToId { get; set; }
    //    [Required]
    //    public int CategoryId { get; set; }
    //    [Required]
    //    public int AssociatedMessageId { get; set; }
    //    public DateTime? Created { get; set; }
    //    [StringLength(1000, MinimumLength = 20)]
    //    public string Notes { get; set; }
    //    [Required]
    //    public bool Completed { get; set; }

    //    //Navigation Properties
    //    public virtual Admin AssignedTo { get; set; }
    //    public virtual Message AssociatedMessage { get; set; }
    //    public virtual Category Category { get; set; }

    //    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    //    {
    //        var errors = new List<ValidationResult>();

    //        if (Completed && string.IsNullOrWhiteSpace(Notes))
    //        {
    //            errors.Add(new ValidationResult("Notes are required when completing a task"));
    //        }

    //        return errors;
    //    }
    //}
}