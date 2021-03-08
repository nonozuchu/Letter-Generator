using UnityEngine;
using UnityEngine.Serialization;

namespace Messenger.GeneralKingdomData
{
    [CreateAssetMenu( menuName = "Writing Style", fileName = "New Writing Style")]
    public class WritingStyle : ScriptableObject
    {
        public Font kingsFont;        
        
        public Paragraphs paragraphsStyle;
    }
}
