using UnityEngine;

public class Rotate_Camera : MonoBehaviour
{
    public Transform cameraTranform;

    bool isRotating;

    public float rotSpeed = 50f;
    public float maxRot = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isRotating = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isRotating == true)
        {
            float currentY = cameraTranform.eulerAngles.y;

            if (currentY > 180) currentY -= 360;

            float newY = Mathf.MoveTowards(currentY, maxRot, rotSpeed * Time.deltaTime);

            cameraTranform.rotation = Quaternion.Euler(0, newY, 0);

            if (Mathf.Approximately(newY, maxRot)) isRotating = false;
        }
    }

    public void SetMaxRot(float angle)
    {
        maxRot = angle;

        isRotating = true;
    }

    public void StopRot()
    {
        isRotating = false;
    }
}
