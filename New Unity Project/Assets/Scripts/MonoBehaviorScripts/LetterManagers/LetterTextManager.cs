
using TMPro;
using UnityEngine;

namespace Messenger.MonoBehaviorScripts.LetterManagers
{
    public class LetterTextManager : MonoBehaviour
    {
        [SerializeField] private LetterManager letterManager;
        
        private string _letterText;
        private void Start()
        {
            var paragraphsStyle = letterManager.senderKingdom.king.kingWritingStyle.paragraphsStyle;


            GenerateRandomTextFromParagraphs(paragraphsStyle.firstParagraphsOptions);
            GenerateRandomTextFromParagraphs(paragraphsStyle.secondParagraphsOptions);
            GenerateRandomTextFromParagraphs(paragraphsStyle.thirdParagraphsOptions);
            GenerateRandomTextFromParagraphs(paragraphsStyle.fourthParagraphsOptions);


            GetComponent<TextMeshProUGUI>().text = 
                _letterText + $"\nFrom: {letterManager.senderKingdom.kingdomName} \n";
        }

        private void GenerateRandomTextFromParagraphs(string[] paragraphsOptions)
        {
            _letterText += paragraphsOptions[Random.Range(0, paragraphsOptions.Length)] + "\n";
        }
    }
}
