using System.ComponentModel.DataAnnotations;
using System;
using BeltExamCSharp.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace BeltExamCSharp.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        // MySQL VARCHAR and TEXT types can be represeted by a string
        [Required]
        [MinLength(2, ErrorMessage = "First name has to be atleast 2 characters!")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Last name has to be atleast 2 characters!")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter correct email or change other email!")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Password has to be atleast 8 characters!")]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[$@$!%*#?&])[A-Za-z\d$@$!%*#?&]{8,}$", ErrorMessage = "Password must contain 1 letter, 1 number and 1 special character and MUST be 8 characters long")]
        public string Password { get; set; }
        // The MySQL DATETIME type can be represented by a DateTime
        public DateTime Created_at { get; set; } = DateTime.Now;
        public DateTime Updated_at { get; set; } = DateTime.Now;

        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string ConfirmPw { get; set; }

        public List<ActConnect> UsertoAct { get; set; }

    }
    public class LoginUser
    {
        // No other fields!
        [Required(ErrorMessage = "Please enter correct email!")]
        [EmailAddress]
        public string LoginEmail { get; set; }

        [Required(ErrorMessage = "Please enter your password!")]
        [DataType(DataType.Password)]
        public string LoginPassword { get; set; }
    }

    public class NewActivity
    {
        [Key]
        public int ActivityId { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Title has to be atleast 2 characters!")]
        public string Title { get; set; }
        [Required]
        [RegularExpression(@"\b((1[0-2]|0?[1-9]):([0-5][0-9]) ([AaPp][Mm]))", ErrorMessage="Please make sure your time is chosen hh/mm AM or PM")]
        public string Time { get; set; }
        [Required]
        public DateTime ActDate { get; set; }
        [Required]
        [RegularExpression(@"^[+]?\d+([.]\d+)?$", ErrorMessage = "Only positive numbers allowed")]
        public int Duration { get; set; }
        [MinLength(10, ErrorMessage = "Description has to be atleast 10 characters!")]
        public string Description {get; set;}
        public User Coordinator {get; set;}
        public int UserId {get; set;}

        public DateTime Created_at { get; set; } = DateTime.Now;
        public DateTime Updated_at { get; set; } = DateTime.Now;
        public List<ActConnect> ActtoUser { get; set; }
    }

    public class ActConnect
    {
        [Key]
        public int ActConnectId { get; set; }
        public int UserId { get; set; }
        public int ActivityId { get; set; }
        public User User { get; set; }
        public NewActivity Activity { get; set; }
    }

}