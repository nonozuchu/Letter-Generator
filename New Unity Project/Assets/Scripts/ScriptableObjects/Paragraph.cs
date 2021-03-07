using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu( menuName = "Letter Paragraphs", fileName = "paragraph")]
public class Paragraph : ScriptableObject
{
    [TextArea(15,20)]
    public string[] possibleParagraphText;
}
