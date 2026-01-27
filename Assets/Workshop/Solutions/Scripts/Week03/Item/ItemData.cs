using UnityEngine;

namespace Solution
{
    public class ItemData : MonoBehaviour
    {
        public string ItemName;
        public Sprite icon;
        [TextArea] public string description;
        public void Use(Identity identity)
        {
            Debug.Log("Use Item by" + identity.Name);
        }
    }
}
