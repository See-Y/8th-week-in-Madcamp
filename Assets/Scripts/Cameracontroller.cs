using UnityEngine;
using UnityEngine.XR;

public class Cameracontroller : MonoBehaviour
{
    private bool isMovementEnabled = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
           if (!isMovementEnabled) return; // 움직임 비활성화 시 동작 중단
    }
        public void DisableMovement()
    {
        isMovementEnabled = false;

        // VR 헤드셋 위치 고정
        XRDevice.DisableAutoXRCameraTracking(Camera.main, true);
    }

}
