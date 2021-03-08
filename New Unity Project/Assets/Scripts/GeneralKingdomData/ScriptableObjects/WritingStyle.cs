using UnityEngine;

namespace Messenger.GeneralKingdomData.ScriptableObjects
{
    [CreateAssetMenu( menuName = "Writing Style", fileName = "New Writing Style")]
    public class WritingStyle : ScriptableObject
    {
        public Font kingsFont;        
        
        public Paragraphs paragraphsStyle;
    }
}
