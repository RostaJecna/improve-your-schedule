using System.Collections.Generic;
using System.Linq;
using ImproveYourSchedule.Enums;
using ImproveYourSchedule.Models;

namespace ImproveYourSchedule.Data
{
    internal static class Subjects
    {
        private static List<Subject> AllSubjects { get; } = new List<Subject>
        {
            new Subject(SubjectType.C, Teachers.Su),
            new Subject(SubjectType.E, Teachers.Ju),
            new Subject(SubjectType.M, Teachers.Ng),
            new Subject(SubjectType.Phe, Teachers.Lc),
            new Subject(SubjectType.Se, Teachers.Ma),
            new Subject(SubjectType.Ds, Teachers.Ka),
            new Subject(SubjectType.Eis, Teachers.Bc),
            new Subject(SubjectType.Csn, Teachers.Ms),
            new Subject(SubjectType.Am, Teachers.Kl),
            new Subject(SubjectType.Eit, Teachers.Mz),
            new Subject(SubjectType.Wa, Teachers.Pv),
            new Subject(SubjectType.Tp, Teachers.No)
        };
        
        internal static Dictionary<SubjectType, Subject> SubjectDictionary { get; } = AllSubjects.ToDictionary(subject => subject.Type, subject => subject);
    }
}