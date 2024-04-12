using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class RotateAroundBA : MonoBehaviour {
	
	[SerializeField] private Transform targetT;
	[SerializeField] private float distance= 5.0f;
	[SerializeField] private float xSpeed= 250.0f;
	[SerializeField] private float ySpeed= 120.0f;
	[SerializeField] private float yMinLimit= -20;
	[SerializeField] private float yMaxLimit= 80;
	public float rotationSpeed;
	private float _x= 0.0f;
	private float _y= 0.0f;
	private float _xx;
	private float _yy;
	private Vector3 _position = new Vector3();
	private Quaternion _rotationN;

	private static bool _isDrag;
	private static bool _isMousePressed;
	private float _counter;
	private Vector3 _mouseUpPosition;
	private Vector3 _mouseDownPosition;
	private float _xMouseMoved;
	private float _yMouseMoved;



	private void  Start (){
		_isDrag = false;
		Vector3 angles = transform.eulerAngles;
		_x = angles.y;
		_y = angles.x;

		if (GetComponent<Rigidbody>())
			GetComponent<Rigidbody>().freezeRotation = true;
		_rotationN = Quaternion.Euler(_y, _x, 0);
		_position = _rotationN * new Vector3(0.0f, 0.0f, -distance) + targetT.position;

		transform.rotation = _rotationN;
		transform.position = _position;
	}

	private void Update(){
		if(Application.isMobilePlatform){
			if(Input.touchCount > 1){
				_isDrag = false;
			}
		}
	}

	private void LateUpdate (){
		if(Application.isMobilePlatform){
			if (targetT && _isDrag) {
				_x += Input.touches[0].deltaPosition.x * xSpeed * 0.008f;
				_y -= Input.touches[0].deltaPosition.y * ySpeed * 0.008f;
				_y = ClampAngle(_y, yMinLimit, yMaxLimit);
				_rotationN = Quaternion.Euler(_y, _x, 0);
				_position = _rotationN * new Vector3(0.0f, 0.0f, -distance) + targetT.position;
				transform.rotation = _rotationN;
				transform.position = _position;
			}
			else if(targetT){
				_x += Time.deltaTime * xSpeed * 0.02f * rotationSpeed;
				_y = ClampAngle(_y, yMinLimit, yMaxLimit);
				_rotationN = Quaternion.Euler(_y, _x, 0);
				_position = _rotationN * new Vector3(0.0f, 0.0f, -distance) + targetT.position;
				transform.rotation = _rotationN;
				transform.position = _position;		
			}
		}
		else{
			if (targetT && _isDrag){
				_x += Input.GetAxis("Mouse X") * xSpeed * 0.02f;
				_y -= Input.GetAxis("Mouse Y") * ySpeed * 0.02f;
				_y = ClampAngle(_y, yMinLimit, yMaxLimit);
				_rotationN = Quaternion.Euler(_y, _x, 0);
				_position = _rotationN * new Vector3(0.0f, 0.0f, -distance) + targetT.position;
				transform.rotation = _rotationN;
				transform.position = _position;
			}
			else if(targetT)	{
				_x += Time.deltaTime * xSpeed * 0.02f * rotationSpeed;
				_y = ClampAngle(_y, yMinLimit, yMaxLimit);
				_rotationN = Quaternion.Euler(_y, _x, 0);
				_position = _rotationN * new Vector3(0.0f, 0.0f, -distance) + targetT.position;
				transform.rotation = _rotationN;
				transform.position = _position;		
			}
		}
	}

	private static float  ClampAngle ( float angle ,   float min ,   float max  ){
		if (angle < -360)
			angle += 360;
		if (angle > 360)
			angle -= 360;
		return Mathf.Clamp (angle, min, max);
	}

	// Update is called once per frame
	private void OnGUI () {
		if(Application.isMobilePlatform){
			if(Input.touchCount > 1){
				_isDrag = false;
			}
		}
		//Debug.Log (isDrag);
		if (Event.current.type == EventType.MouseDown) {
			if(Application.isMobilePlatform){			
				_mouseDownPosition = Input.touches[0].position;
			}
			else{
				_mouseDownPosition = Input.mousePosition;
			}
			_isMousePressed = true;
		}
		else if(Event.current.type == EventType.MouseDrag){
			CancelInvoke("StartCountingG");
			_counter = 0f;
			_isDrag=true;
		}
		else if(Event.current.type == EventType.MouseUp){
			_isMousePressed = false;
			if(Application.isMobilePlatform){				
				_mouseUpPosition = Input.touches[0].position;
			}
			else{
				_mouseUpPosition = Input.mousePosition;
			}
			_xMouseMoved = Mathf.Abs(_mouseUpPosition.x - _mouseDownPosition.x);
			_yMouseMoved = Mathf.Abs(_mouseUpPosition.y - _mouseDownPosition.y);
			//if the makes a small drag, consider it click
			if((_xMouseMoved < 5f) || (_yMouseMoved < 5f)){
				_isDrag = false;
			}
			else{
				InvokeRepeating(nameof(StartCountingG), 0.02f, 0.02f);
			}
		}
	}

	//we need this method so that Raycast won't be activated if we release the mouse button or the swipe, only on touches, not on drag
	private void StartCountingG(){
		_counter += Time.deltaTime;
		if(_counter > 0.01f){
			_isDrag = false;
		}
	}

}