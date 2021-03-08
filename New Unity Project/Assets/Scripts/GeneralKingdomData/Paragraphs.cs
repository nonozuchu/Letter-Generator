using UnityEngine;
using UnityEngine.Serialization;

namespace Messenger.GeneralKingdomData
{
    [CreateAssetMenu( menuName = "Paragraph", fileName = "Type+paragraphs")]
    public class Paragraphs : ScriptableObject
    {
        public string[] firstParagraphsOptions;
        public string[] secondParagraphsOptions;
        public string[] thirdParagraphsOptions;
        public string[] fourthParagraphsOptions;
        

        public string GenerateRandomTextFromParagraphs(string paragraphsCombined)
        {
            paragraphsCombined += firstParagraphsOptions[Random.Range(0, firstParagraphsOptions.Length)] + "\n";
            paragraphsCombined += secondParagraphsOptions[Random.Range(0, secondParagraphsOptions.Length)] + "\n";
            paragraphsCombined += thirdParagraphsOptions[Random.Range(0, thirdParagraphsOptions.Length)] + "\n";
            paragraphsCombined += fourthParagraphsOptions[Random.Range(0, fourthParagraphsOptions.Length)] + "\n";
            return paragraphsCombined;
        }

    }
}
