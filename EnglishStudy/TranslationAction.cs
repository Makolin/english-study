using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnglishStudy
{
    class TranslationAction
    {
        public List<Translation> InputTranslationList;
        public List<Translation> ExportTranslationList;
        public TranslationAction()
        {
            InputTranslationList = new List<Translation>();
            ExportTranslationList = new List<Translation>();

            InputTranslationList.Add(new Translation(1, EnglishTense.FutureSimpleQuestions, "Will I came?", "Я буду приходить?"));
            InputTranslationList.Add(new Translation(1, EnglishTense.FutureSimpleQuestions, "Will he give?", "Он будет давать?"));
            InputTranslationList.Add(new Translation(1, EnglishTense.FutureSimpleQuestions, "Will she take?", "Она будет брать?"));

            InputTranslationList.Add(new Translation(2, EnglishTense.FutureSimpleQuestions, "How will she come to him?", "Как она придет к нему?"));
            InputTranslationList.Add(new Translation(2, EnglishTense.FutureSimpleQuestions, "When will you go to London?", "Когда ты поедешь в Лондон?"));

            InputTranslationList.Add(new Translation(1, EnglishTense.FutureSimpleAffirmative, "I will know.", "Я буду знать. "));
            InputTranslationList.Add(new Translation(1, EnglishTense.FutureSimpleAffirmative, "He will ask.", "Он будет спрашивать."));
            InputTranslationList.Add(new Translation(1, EnglishTense.FutureSimpleAffirmative, "She will answer.", "Она будет отвечать."));

            InputTranslationList.Add(new Translation(2, EnglishTense.FutureSimpleAffirmative, "He will come to me.", "Он придет ко мне."));
            InputTranslationList.Add(new Translation(2, EnglishTense.FutureSimpleAffirmative, "I will travel with you.", "Я буду путешествовать с тобой."));

            InputTranslationList.Add(new Translation(1, EnglishTense.FutureSimpleNegative, "I will not help.", "Я не буду помогать."));
            InputTranslationList.Add(new Translation(1, EnglishTense.FutureSimpleNegative, "He will not hope.", "Он не будет надеяться. "));
            InputTranslationList.Add(new Translation(1, EnglishTense.FutureSimpleNegative, "She will not speak.", "Она не будет разговаривать."));

            InputTranslationList.Add(new Translation(2, EnglishTense.FutureSimpleNegative, "I will not open door.", "Я не буду открывать дверь."));
            InputTranslationList.Add(new Translation(2, EnglishTense.FutureSimpleNegative, "I will not play with her.", "Я не буду играть с ней."));

            InputTranslationList.Add(new Translation(1, EnglishTense.PresentSimpleQuestions, "Do I start?", "Я начинаю?"));
            InputTranslationList.Add(new Translation(1, EnglishTense.PresentSimpleQuestions, "Does he close?", "Он закрывает?"));
            InputTranslationList.Add(new Translation(1, EnglishTense.PresentSimpleQuestions, "Does she open?", "Она открывает?"));
            InputTranslationList.Add(new Translation(1, EnglishTense.PresentSimpleQuestions, "Does he see her?", "Он видит её?"));

            InputTranslationList.Add(new Translation(2, EnglishTense.PresentSimpleQuestions, "Where do you live and work?", "Где ты живешь и работаешь?"));

            InputTranslationList.Add(new Translation(1, EnglishTense.PresentSimpleAffirmative, "I live.", "Я живу."));
            InputTranslationList.Add(new Translation(1, EnglishTense.PresentSimpleAffirmative, "He reads.", "Он читает."));
            InputTranslationList.Add(new Translation(1, EnglishTense.PresentSimpleAffirmative, "She plays.", "Она играет."));

            InputTranslationList.Add(new Translation(2, EnglishTense.PresentSimpleAffirmative, "He sees him.", "Он видит его."));
            InputTranslationList.Add(new Translation(2, EnglishTense.PresentSimpleAffirmative, "He sees them.", "Он видит их."));
            InputTranslationList.Add(new Translation(2, EnglishTense.PresentSimpleAffirmative, "I see a bird on the roof.", "Я вижу птицу на крыше."));
            InputTranslationList.Add(new Translation(2, EnglishTense.PresentSimpleAffirmative, "She travels with children.", "Она путешествует в детьми."));

            InputTranslationList.Add(new Translation(1, EnglishTense.PresentSimpleNegative, "I don't love.", "Я не люблю."));
            InputTranslationList.Add(new Translation(1, EnglishTense.PresentSimpleNegative, "He doesn't finish.", "Он не заканчивает."));
            InputTranslationList.Add(new Translation(1, EnglishTense.PresentSimpleNegative, "She doesn't see.", "Она не смотрит."));

            InputTranslationList.Add(new Translation(2, EnglishTense.PresentSimpleNegative, "He doesn't see us", "Он не видит нас."));
            InputTranslationList.Add(new Translation(2, EnglishTense.PresentSimpleNegative, "He doesn't know her", "Он не знает её."));
            InputTranslationList.Add(new Translation(2, EnglishTense.PresentSimpleNegative, "I don't see you", "Я не вижу тебя."));
            InputTranslationList.Add(new Translation(2, EnglishTense.PresentSimpleNegative, "She doesn't drink", "Она не пьет."));

            InputTranslationList.Add(new Translation(1, EnglishTense.PastSimpleQuestions, "Did I find?", "Я находил?"));
            InputTranslationList.Add(new Translation(1, EnglishTense.PastSimpleQuestions, "Did he work?", "Он работал?"));
            InputTranslationList.Add(new Translation(1, EnglishTense.PastSimpleQuestions, "Did she need?", "Она нуждалась?"));

            InputTranslationList.Add(new Translation(2, EnglishTense.PastSimpleQuestions, "Did I go to home?", "Я шел домой?"));
            InputTranslationList.Add(new Translation(2, EnglishTense.PastSimpleQuestions, "Who did know her?", "Кто знал её?"));

            InputTranslationList.Add(new Translation(1, EnglishTense.PastSimpleAffirmative, "I traveled.", "Я путешествовал."));
            InputTranslationList.Add(new Translation(1, EnglishTense.PastSimpleAffirmative, "He studied.", "Он изучал."));
            InputTranslationList.Add(new Translation(1, EnglishTense.PastSimpleAffirmative, "She wrote.", "Она писала."));

            InputTranslationList.Add(new Translation(2, EnglishTense.PastSimpleAffirmative, "He opened her", "Он открыл её."));
            InputTranslationList.Add(new Translation(2, EnglishTense.PastSimpleAffirmative, "I asked you.", "Я спрашивал тебя."));
            InputTranslationList.Add(new Translation(2, EnglishTense.PastSimpleAffirmative, "She came to us.", "Она пришла к нам."));
            InputTranslationList.Add(new Translation(2, EnglishTense.PastSimpleAffirmative, "I took toy.", "Я взял игрушку."));

            InputTranslationList.Add(new Translation(1, EnglishTense.PastSimpleNegative, "I didn't try.", "Я не пытался."));
            InputTranslationList.Add(new Translation(1, EnglishTense.PastSimpleNegative, "He didn't feel.", "Он не чувствовал."));
            InputTranslationList.Add(new Translation(1, EnglishTense.PastSimpleNegative, "She didn't run.", "Она не бегала."));

            InputTranslationList.Add(new Translation(2, EnglishTense.PastSimpleNegative, "I didn't answer him", "Я не отвечал ему"));
            InputTranslationList.Add(new Translation(2, EnglishTense.PastSimpleNegative, "I didn't come to her", "Я не пришел к ней."));
        }

        public void OneLevelStudy(int currentlevel)
        {
            Random random = new Random();
            InputTranslationList = InputTranslationList.Where(t => t.levelStudy == currentlevel).ToList();
            var sortRandomEnum = new Translation();
            foreach (EnglishTense currentTense in sortRandomEnum.SortRandom())
            {
                var currentTenseList = InputTranslationList.Where(t => t.tense == currentTense).ToList();
                var number = random.Next(0, currentTenseList.Count());
                ExportTranslationList.Add(currentTenseList[number]);
            }
        }
    }
}
