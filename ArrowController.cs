using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    Transform player;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player").transform;
        //2////일정 시간이후에 삭제됨
        //Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        //1//화살표 이동속도
        transform.Translate(0, -0.02f, 0);

        Vector2 p1 = transform.position;//화살표위치
        Vector2 p2 = player.position;//플레이어 위치
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;//벡터 길이를 구해주는 프로퍼티
        float r1 = .5f;//화살표의 반지름
        float r2 = 0.8f;//고양이의 반지름

        //닿았거나, 범위안에 들어왔다면
        if(d <= r1+r2)
        {
            //즉시삭제
            Destroy(gameObject);
        }

        //1
        if((transform.position - player.position).magnitude < 1.3f)
        {
            destroy(gameobject);

        }

        //2//범위를 넘어갔다면
        if (transform.position.y <= -6f || transform.position.y >= 6f || transform.position.x <= -10f || transform.position.x >= 10f )
        {
            //즉시삭제
            Destroy(gameObject);
        }
        

    }
}
