using UnityEngine;

public class ObstaclesController : MonoBehaviour
{
    public float obstaclesSpeed = 1.0f;

    private void Start()
    {
        if (DifficultySelect.easy)
        {
            obstaclesSpeed = 10f;
        }

        if (DifficultySelect.medium)
        {
            obstaclesSpeed = 20f;
        }
        if (DifficultySelect.hard)
        {
            obstaclesSpeed = 30f;
        }
    }

    void Update()
    {
        MoveObstacles();
    }

    private void MoveObstacles()
    {
        this.gameObject.transform.Translate(-obstaclesSpeed * Time.deltaTime, 0, 0);
    }
}
