using UnityEngine;

public class Tile : MonoBehaviour 
{
    private void OnDrawGizmos()
    {
        SpriteRenderer[] renderer = GetComponentsInChildren<SpriteRenderer>();

        if (renderer != null)
        {
            for (int i = 0; i < renderer.Length; i++)
            {
                renderer[i].sortingOrder = (int)(transform.position.y * 10 * -1);
            }
        }
    }
}