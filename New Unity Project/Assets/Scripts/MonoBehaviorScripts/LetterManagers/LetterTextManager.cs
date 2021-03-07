using Messenger.CoreData;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

namespace Messenger.MonoBehaviorScripts.LetterManagers
{
    public class LetterTextManager : MonoBehaviour
    {
        [Header("Letter Paragraphs")]
        [SerializeField] private Paragraph firstParagraph;
        [SerializeField] private Paragraph secondParagraph;
        [SerializeField] private Paragraph thirdParagraph;
        [SerializeField] private Paragraph fourthParagraph;
        private string _letterText;
        private void Start()
        {
            GenerateRandomText(firstParagraph);
            GenerateRandomText(secondParagraph);
            GenerateRandomText(thirdParagraph);
            GenerateRandomText(fourthParagraph);

            GetComponent<TextMeshProUGUI>().text = _letterText;
        }

        void GenerateRandomText(Paragraph _paragraph)
        {
            _letterText += _paragraph.possibleParagraphText[Random.Range(0, _paragraph.possibleParagraphText.Length)] + "\n";
        }
    }
}
