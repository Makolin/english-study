using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnglishStudy
{
    public enum EnglishTense
    {
        FutureSimpleAffirmative,
        FutureSimpleNegative,
        FutureSimpleQuestions,
        PresentSimpleAffirmative,
        PresentSimpleNegative,
        PresentSimpleQuestions,
        PastSimpleAffirmative,
        PastSimpleNegative,
        PastSimpleQuestions
    }

    public class Translation
    {
        public int levelStudy;
        public EnglishTense tense;
        public string englishLanguage;
        public string russianLanguage;
        public Translation()
        {

        }
        public Translation(int levelStudy, EnglishTense tense, string englishLanguage, string russianLanguage)
        {
            this.levelStudy = levelStudy;
            this.tense = tense;
            this.englishLanguage = englishLanguage;
            this.russianLanguage = russianLanguage;
        }
        public List<EnglishTense> SortRandom()
        {
            var sortRandomEnum = new List<EnglishTense>();
            foreach (EnglishTense currentTense in Enum.GetValues(typeof(EnglishTense)))
            {
                sortRandomEnum.Add(currentTense);
            }
            sortRandomEnum = sortRandomEnum.OrderBy(t => Guid.NewGuid().ToString()).ToList();
            return sortRandomEnum;
        }
    }
}
