using UnityEngine;
using System.Collections;

public class Parallax : MonoBehaviour
{
    // 일정한 속도로 지나가는 배경을 생성한다.
    // 로직은 원본과 복사본 2개를 가지고 이어붙여서 좌측으로 지나가게 한다.
    // 배경 한계선에 다다르면 왼쪽 객체를 오른쪽 객체 끝으로 옮겨서 계속 돌면서 지나가게 만든다.

    // 속도
    public float ParallaxSpeed=0;
    public int gap=0;

	protected GameObject _clone;
	protected Vector3 _movement;
	protected Vector3 _initialPosition;
	protected float _width;

    protected virtual void Start()
	{
		_width = GetComponent<Renderer>().bounds.size.x + gap;
		_initialPosition=transform.position;
        // 복사본을 만들어서 오른쪽 끝에 붙인다.
		_clone = (GameObject)Instantiate(gameObject,
                                         new Vector3(transform.position.x+_width,
                                                     transform.position.y,
                                                     transform.position.z),
                                         transform.rotation);
        // 복사본을 만들때 스크립트 중복 실행을 막기 위해 뒤쪽 객체의 스크립트를 없앤다.
        // 즉, 이 스크립트에서 두 객체를 컨트롤한다.
		Parallax parallaxComponent = _clone.GetComponent<Parallax>();
		Destroy(parallaxComponent);
	}

    protected virtual void FixedUpdate()
	{
	    // 적용할 거리를 계산한다.
        _movement = Vector3.left * (ParallaxSpeed/10) * Time.fixedDeltaTime;

        // 두 객체 위치 모두 업뎃
        _clone.transform.Translate(_movement);
		transform.Translate(_movement);

		// 왼쪽 한계선에 도달하면 두 객체를 같은 폭만큼 우측으로 움직인다.
        // (겉으로 볼때는 좌측객체가 우측객체의 우측으로 옮겨진 것 같이 보인다.)
		if (transform.position.x +_width < _initialPosition.x)
		{
			transform.Translate(Vector3.right * _width);
			_clone.transform.Translate(Vector3.right * _width);
		}
	}
}