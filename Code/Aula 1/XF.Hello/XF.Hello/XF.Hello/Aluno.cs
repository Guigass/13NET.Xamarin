using System;
using System.Collections.Generic;
using System.Text;

namespace XF.Hello
{
    public class Aluno
    {
        public Guid id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string RM
        {
            get
            {
                return id.ToString();
            }
        }
    }
}
