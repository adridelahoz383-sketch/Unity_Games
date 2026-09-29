using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [SerializeField] private float secondsPerDay = 60f;

    void Update()
    {
        float rotationSpeed = 360f / secondsPerDay;
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}