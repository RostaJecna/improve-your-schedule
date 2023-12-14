using System;
using ImproveYourSchedule.Enums;

namespace ImproveYourSchedule.Models
{
    public class Subject
    {
        private readonly SubjectType _type;
        private readonly Teacher _teacher;
        
        public Subject(SubjectType subjectType, Teacher teacher)
        {
            _type = subjectType;
            _teacher = teacher;
        }
        
        public SubjectType Type => _type;

        public Teacher Teacher => _teacher;

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Subject subject = (Subject)obj;
            return _type == subject.Type && _teacher.Equals(subject.Teacher);
        }

        public override int GetHashCode() => Tuple.Create(_type, _teacher).GetHashCode();

        public override string ToString() => $"{_type.ToString()}: {_teacher}";
    }
}