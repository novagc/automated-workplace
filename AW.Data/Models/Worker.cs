using System.ComponentModel.DataAnnotations;
using System.Linq;
using AW.Data.Models.Enums;

namespace AW.Data.Models
{
    public class Worker: IValidable
    {
        public int Id { get; set; }

        [Required]
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public Role Role { get; set; }

        public bool Validate()
        {
            var temp = new[] {Login, FirstName, MiddleName, LastName};
            return !temp.All(string.IsNullOrEmpty);
        }

        public Worker Copy()
        {
            return new Worker
            {
                Id = Id,
                Login = Login,
                Password = Password,
                FirstName = FirstName,
                MiddleName = MiddleName,
                LastName = LastName,
                Role = Role
            };
        }

        public override string ToString()
        {
            return $"{Login}";
        }
    }
}
