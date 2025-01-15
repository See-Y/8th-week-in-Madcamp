using UnityEngine;
using UnityEngine.XR;

public class SprintController : MonoBehaviour
{
    public XRNode inputSource;      // 트리거를 감지할 XR 컨트롤러 (오른손/왼손)

    private InputDevice device;

    public float sprintSpeed = 4.0f; // 스프린트 속도
    private float normalSpeed = 2.0f; // 일반 속도

    void Start()
    {
        // XR Input Device 가져오기
        device = InputDevices.GetDeviceAtXRNode(inputSource);
    }

    void Update()
    {
        if (device.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue))
        {
            // 트리거 값이 0.1 이상이면 (눌렀다고 판단)
            if (triggerValue > 0.1f)
            {
                OnTriggerPressed(triggerValue);
            }
        }
    }

    private void OnTriggerPressed(float triggerValue)
    {
        // 트리거 눌림 이벤트 처리
        Debug.Log("Trigger pressed with value: " + triggerValue);
    }

}
