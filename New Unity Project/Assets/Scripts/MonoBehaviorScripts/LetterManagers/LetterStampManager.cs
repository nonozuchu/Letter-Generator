using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Messenger.MonoBehaviorScripts.LetterManagers
{
    public class LetterStampManager : MonoBehaviour
    {
        [SerializeField] private LetterManager letterManager;
        public void Start()
        {
            GetComponent<Image>().sprite =  letterManager.senderKingdom.kingdomStamp;
        }
    }
}
