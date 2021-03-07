using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LetterTextManager : MonoBehaviour
{
    [Header("Letter Paragraphs")]
    [SerializeField] Paragraph _firstParagraph;
    [SerializeField] Paragraph _secondParagraph;
    [SerializeField] Paragraph _thirdParagraph;
    [SerializeField] Paragraph _fourthParagraph;
    string _letterText;
    void Start()
    {
        GenerateRandomText(_firstParagraph);
        GenerateRandomText(_secondParagraph);
        GenerateRandomText(_thirdParagraph);
        GenerateRandomText(_fourthParagraph);

        GetComponent<TextMeshProUGUI>().text = _letterText;
    }

    void GenerateRandomText(Paragraph _paragraph)
    {
        _letterText += _paragraph.possibleParagraphText[Random.Range(0, _paragraph.possibleParagraphText.Length)] + "\n";
    }
}
