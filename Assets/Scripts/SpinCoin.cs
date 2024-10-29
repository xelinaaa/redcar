using UnityEngine;

public class SpinCoin : MonoBehaviour
{
    // Speed of the spin
    public float spinSpeed = 100f;

    void Update()
    {
        // Rotate the coin around its Y-axis
        transform.Rotate(0, spinSpeed * Time.deltaTime, 0);
    }
}
