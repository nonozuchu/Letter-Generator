using UnityEngine;

namespace Messenger.CoreData
{
    [CreateAssetMenu( menuName = "Letter Paragraphs", fileName = "paragraph")]
    public class Paragraph : ScriptableObject
    {
        [TextArea(15,20)]
        public string[] possibleParagraphText;
    }
}
