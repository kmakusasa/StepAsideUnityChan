using UnityEngine;

class ItemCleaner : MonoBehaviour
{

    void Updete()
    {
        if (this.transform.position.z < Camera.main.transform.position.z)
        {
            Destroy(this.gameObject);
        }
    }
}