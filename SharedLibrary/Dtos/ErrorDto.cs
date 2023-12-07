using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Dtos
{
    public class ErrorDto
    {
        public List<string> Errors { get; private  set; }
        public bool IsShow { get; set; } // true ise hatayı kullanıcıya göster
        
        public ErrorDto() { 
        Errors = new List<string>();
        }
        public ErrorDto(string error , bool isShow)
        {
            Errors.Add(error);
            isShow = true;
        }
        public ErrorDto(List<string> errors , bool isShow) {
            Errors = Errors;
            
            IsShow = isShow;

        }
    }
}
