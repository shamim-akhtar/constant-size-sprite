using UnityEngine;

public class ConstantScreenSizeForSprite : 
  MonoBehaviour
{
  // Set the original camera size. 
  // This is the camera size when your
  // sprite size is just right.
  [SerializeField]
  float OriginalCameraSize = 10.0f;

  // Set the original scale of the sprite.
  [SerializeField]
  Vector3 OrigScale = Vector3.one;

  void LateUpdate()
  {
    if (Camera.main.orthographicSize > 0.1f)
    {
      transform.localScale = 
        Camera.main.orthographicSize / 
        OriginalCameraSize * OrigScale;
    }
  }
}
