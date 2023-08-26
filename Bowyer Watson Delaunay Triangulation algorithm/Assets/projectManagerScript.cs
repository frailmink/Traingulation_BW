using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class projectManagerScript : MonoBehaviour
{
    
    class triangle
    {
        private Vector2 pointA;
        private Vector2 pointB;
        private Vector2 pointC;

        public void SetPoints(Vector2 A, Vector2 B, Vector2 C)
        {
            pointA = A;
            pointB = B;
            pointC = C;
        }

        public List<Vector2> GetPoints()
        {
            List<Vector2> points = new List<Vector2>();
            points.Add(pointA);
            points.Add(pointB);
            points.Add(pointC);

            return points;
        }
    }

    private triangle supraTraingle = new triangle();
    public Vector2 supA;
    public Vector2 supB;
    public Vector2 supC;

    private CreatePoint input;
    private InputAction addPoint;
    public GameObject point;
    public GameObject line;
    private LineScript lineScript;

    private List<Vector2> points = new List<Vector2>();
    private Vector2 mWorldPos;
    private Vector2 mPos;

    // Start is called before the first frame update
    void Awake()
    {
        supraTraingle.SetPoints(supA, supB, supC);

        DrawLines(supraTraingle.GetPoints());

        input = new CreatePoint();

        addPoint = input.point.add;
        addPoint.Enable();
        addPoint.performed += AddNewPoint;
    }

    private void OnEnable()
    {
        addPoint.Enable();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void AddNewPoint(InputAction.CallbackContext context)
    {
        // var rayHit = Physics2D.GetRayIntersection(mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue()));
        // Instantiate(point, new Vector3(Random.Range(-10, 10), Random.Range(-5, 5), 0), transform.rotation);
        mPos = Mouse.current.position.ReadValue();
        mWorldPos = Camera.main.ScreenToWorldPoint(mPos);
        points.Add(mWorldPos);
        Instantiate(point, mWorldPos, transform.rotation);
    }

    private void DrawLines(List<Vector2> linePoints)
    {
        // remember to do this => linePoints = new List<Vector2>();
        line = Instantiate(line, mWorldPos, transform.rotation);
        lineScript = line.GetComponent<LineScript>();
        lineScript.SetUpLine(linePoints);
    }

    private void OnDisable()
    {
        input.Disable();
    }
}
