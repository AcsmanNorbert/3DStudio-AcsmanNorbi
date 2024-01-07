using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField] int value = 1;
    [SerializeField] Bounds teleportArea;

    public int GetAmount()
    {
        return value;
    }

    public void OnCollect()
    {
        Vector3 teleportLocation = new (
            Random.Range(teleportArea.min.x, teleportArea.max.x),
            Random.Range(teleportArea.min.y, teleportArea.max.y),
            Random.Range(teleportArea.min.z, teleportArea.max.z));
        transform.position = teleportLocation;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.black;
        Gizmos.DrawWireCube(teleportArea.center, teleportArea.size);
    }
}
    
