using System.ComponentModel.DataAnnotations;

namespace BTH_2.Models;

public class Student
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Hãy nhập tên.")]
    [StringLength(100, MinimumLength = 4, ErrorMessage = "Tên phải có ít nhất 4 và tối đa 100 ký tự.")]
    public string? Name { get; set; }
    
    [Required(ErrorMessage ="Email bắt buộc phải được nhập")]
    [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
    public string? Email { get; set; }
    
    [StringLength(100, MinimumLength = 8)]
    [Required]
    public string? Password { get; set; }
    
    [Required(ErrorMessage = "Hãy chọn chi nhánh.")]
    public Branch? Branch { get; set; }
    
    [Required(ErrorMessage = "Hãy chọn giới tính.")]
    public Gender? Gender { get; set; }
    
    public bool IsRegular { get; set; }
    
    [DataType(DataType.MultilineText)]
    [Required(ErrorMessage = "Hãy nhập địa chỉ.")]
    public string? Address { get; set; }
    
    [Range(typeof(DateTime), "1/1/1963", "12/31/2005")]
    [DataType(DataType.Date)]
    [Required]
    public DateTime DateOfBirth { get; set; }
    
    [Required(ErrorMessage = "Bạn chưa nhập Score")]
    [Range(0.0, 10.0, ErrorMessage = "Điểm phải nằm trong khoảng từ 0.0 đến 10.0.")]
    public float Score { get; set; }
    public string? AvatarUrl { get; set; }
}