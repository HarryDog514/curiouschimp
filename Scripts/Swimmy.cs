using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Swimmy : MonoBehaviour
{
	private InputDevice LeftControllerDevice;

	private InputDevice RightControllerDevice;

	public Vector3 LeftControllerVelocity;

	public Vector3 RightControllerVelocity;

	private InputDevice targetDevice;

	private InputDevice targetDevice1;

	public Rigidbody poopyhead;

	public float LMag;

	public float RMag;

	public float sped;

	private void Start()
	{
		LeftControllerDevice = InputDevices.GetDeviceAtXRNode(XRNode.LeftHand);
		RightControllerDevice = InputDevices.GetDeviceAtXRNode(XRNode.RightHand);
	}

	private void Update()
	{
		float value;
		targetDevice.TryGetFeatureValue(CommonUsages.trigger, out value);
		float value2;
		targetDevice1.TryGetFeatureValue(CommonUsages.trigger, out value2);
		targetDevice.TryGetFeatureValue(CommonUsages.deviceVelocity, out LeftControllerVelocity);
		targetDevice1.TryGetFeatureValue(CommonUsages.deviceVelocity, out RightControllerVelocity);
		LMag = LeftControllerVelocity.magnitude;
		RMag = RightControllerVelocity.magnitude;
		if (LMag > 2f || RMag > 2f)
		{
			poopyhead.AddRelativeForce(-(LeftControllerVelocity + RightControllerVelocity) * sped);
		}
	}

	public void LateUpdate()
	{
		List<InputDevice> list = new List<InputDevice>();
		InputDevices.GetDevicesWithCharacteristics(InputDeviceCharacteristics.Controller | InputDeviceCharacteristics.Left, list);
		if (list.Count > 0)
		{
			targetDevice = list[0];
		}
		List<InputDevice> list2 = new List<InputDevice>();
		InputDevices.GetDevicesWithCharacteristics(InputDeviceCharacteristics.Controller | InputDeviceCharacteristics.Right, list2);
		if (list2.Count > 0)
		{
			targetDevice1 = list2[0];
		}
	}
}
