using UnityEngine;

public class RopeCutter : MonoBehaviour
{
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            // Since we don't want to use the ray to go anywhere, that's why we're using Vector2.zero. The ray is just being used as a point, since that's where the impact will be.
            if (hit.collider != null)
            {
                if (hit.collider.CompareTag("Link"))
                {
                    Destroy(hit.collider.gameObject);
                    //Destroy(hit.transform.parent.gameObject, 2f); //This would remove the entire rope after it is cut
                }
            }
        }
    }
}   