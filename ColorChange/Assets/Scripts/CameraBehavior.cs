using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    [SerializeField] private Transform camera;

    [SerializeField] private Transform playerPositionY;
    [SerializeField] private Vector2 highestPositionY;

    private void Awake()
    {
        camera = GetComponent<Transform>();
    }

    private void Update()
    {
        HeightCheck();
        camera.position = new Vector3(camera.position.x, highestPositionY.y, -10);
    }

    private void HeightCheck()
    {
        if (playerPositionY.position.y > highestPositionY.y)
        {
            highestPositionY.y = playerPositionY.position.y;
        }
    }
}
