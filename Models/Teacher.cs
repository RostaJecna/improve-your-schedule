using ImproveYourSchedule.Utilities;

namespace ImproveYourSchedule.Models
{
    public class Teacher
    {
        private readonly string _shortName;

        public Teacher(string shortName)
        {
            _shortName = Validator.CheckNullOrEmpty(shortName, nameof(shortName));
        }
        
        public string ShortName => _shortName;

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Teacher teacher = (Teacher)obj;
            return _shortName.Equals(teacher.ShortName);
        }

        public override int GetHashCode()
        {
            return _shortName.GetHashCode();
        }

        public override string ToString() => _shortName;
    }
}