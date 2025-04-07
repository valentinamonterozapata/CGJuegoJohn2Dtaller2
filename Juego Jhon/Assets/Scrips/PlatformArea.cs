using UnityEngine;

public class PlatformArea : MonoBehaviour
{
    public Vector2 GetRandomPosition()
    {
        BoxCollider2D collider = GetComponent<BoxCollider2D>();
        Bounds bounds = collider.bounds;
        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = bounds.min.y;
        return new Vector2(x, y);
    }
}