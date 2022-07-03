using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor; // unity editor 관련 api를 사용하기위해 선언

public class MyEditorWindow : EditorWindow
{
    #region EditorWindow 다중 생성 방법1

    //static MyEditorWindow window;

    //[MenuItem("MyTool/Open MyTool %g")]
    //static void Open()
    //{
    //    Debug.Log("My Tool 창 열림");

    //    window = CreateInstance<MyEditorWindow>(); // EditorWindow가 생성됨

    //    window.Show();
    //}

    #endregion



    #region 1개의 EditorWindow 생성 방법1

    //static MyEditorWindow window;

    //[MenuItem("MyTool/Open MyTool %g")]
    //static void Open()
    //{
    //    Debug.Log("My Tool 창 열림");

    //     다중 생성을 막으려면 현재 EditorWindow가 생성되었는지 확인
    //    if (window == null)
    //    {
    //        window = CreateInstance<MyEditorWindow>();
    //    }

    //    window.Show();
    //}

    #endregion



    #region 1개의 EditorWindow 생성 방법2

    // 만든 editor window를 오픈을 해줄 함수 선언, static 선언
    // unity editor의 메뉴에서 메뉴창을 선택하면 해당 함수가 실행(호출된다.)
    //MenuItem에서 %g는 단축키를 의미하며 crtl + g를 의미한다.
    // 참고 블로그 https://debuglog.tistory.com/28
    [MenuItem("MyTool/Open MyTool %g")]
    static void Open()
    {
        Debug.Log("My Tool 창 열림");

        // EditorWindow 생성 (한개만 생성됨
        var window = GetWindow<MyEditorWindow>();

        // EditorWindow 이름 설정 (설정안하면 default 값으로 Editor Window가 된다.)
        window.title = "My Tool";
    }
    #endregion



    #region GUI 그리기1

    //// GUI를 그리기 위해서 EditorWindow에서 재공하는 예약된 OnGUI()를 선언해야함 유니티에서 호출해줌
    //private void OnGUI()
    //{
    //    // EditorGUILayout은 값을 설정하기 위한 필드들이 모여있는 클래스이다.
    //    EditorGUILayout.LabelField("Label!!!");
    //    EditorGUILayout.TextField("TextField!!!");

    //    // GUILayout은 대부분 Layout없이 직접 Rect를 지정하여 그리는 필드들이 모여있는 클래스이다.
    //    GUILayout.Button("Button!!!");
    //}

    #endregion



    #region GUI 그리기2

    //private void OnGUI()
    //{
    //    // Layout -> 유니티의 자동 레이아웃 이용하는 형태의 GUI들, 즉 따로 위치를 지정해줄 필요 없음
    //    // GUI / GUILayout : Editor / 런타임용 (빌드후에서 사용가능)
    //    // EditorGUI / EditorGUILayout : Only Editor용

    //    GUI.Label(new Rect(250, 0, 100, 50), "GUI.Label");
    //    EditorGUI.LabelField(new Rect(250, 50, 100, 50), "EditorGUI.LabelField(");

    //    GUILayout.Label("GUILayout.Label");
    //    EditorGUILayout.LabelField("EditorGUILayout.LabelField");
    //}

    #endregion



    #region GUI 그리기3 (사용이 빈번한 GUI 요소 그룹 사용해보기

    //int intValue;
    //float floatValue;
    //Color colorValue;
    //Gradient gradientValue = new Gradient();
    //Vector3 vector3Value;
    //Vector3Int vector3IntValue;
    //Rect rectValue;
    //UnityEngine.Object objectValue;
    //string passwordValue;
    //string tagValue;
    //UnityEngine.ParticleSystemCollisionType enumValue;
    //bool toggleValue;
    //string[] stringArr = new string[] { "String01", "String02", "String03", "String04", "String05", "String06"};
    //int selectionValue;

    //private void OnGUI()
    //{
    //    #region ===:: EditorGUILayout:: ===
    //    // https://blog.naver.com/PostView.naver?blogId=hammerimpact&logNo=220772494827&parentCategoryNo=&categoryNo=&viewDate=&isShowPopularPosts=false&from=postView

    //    // int field
    //    intValue = EditorGUILayout.IntField("int 값", intValue);

    //    // float field
    //    floatValue = EditorGUILayout.FloatField("float 값", floatValue);

    //    // color field
    //    colorValue = EditorGUILayout.ColorField("color 값", colorValue);

    //    // gradient field
    //    gradientValue = EditorGUILayout.GradientField("gradient 값", gradientValue);

    //    // vector3 field
    //    vector3Value = EditorGUILayout.Vector3Field("vector3 값", vector3Value);

    //    // vector3Int field
    //    vector3IntValue = EditorGUILayout.Vector3IntField("vector3Int 값", vector3IntValue);

    //    //rect field
    //    rectValue = EditorGUILayout.RectField("rect 값", rectValue);

    //    // object field
    //    objectValue = EditorGUILayout.ObjectField("obect 값", objectValue, typeof(UnityEngine.Object), false);

    //    // password field
    //    passwordValue = EditorGUILayout.PasswordField("password 값", passwordValue);

    //    // tag 값
    //    tagValue = EditorGUILayout.TagField("tag 값", tagValue);

    //    EditorGUILayout.Space(15);

    //    // enum type field
    //    enumValue = (UnityEngine.ParticleSystemCollisionType)EditorGUILayout.EnumFlagsField("enum 값", enumValue);

    //    // slider
    //    floatValue = EditorGUILayout.Slider("slider", floatValue, 0, 100);

    //    // help box
    //    EditorGUILayout.HelpBox("Help box", MessageType.Error);

    //    // toggle
    //    toggleValue = EditorGUILayout.Toggle("toggle 값", toggleValue);

    //    // 줄 긋기
    //    EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);

    //    #endregion


    //    #region ===:: GUILayout ::===

    //    // toolbar
    //    // https://lunchballer.com/archives/561
    //    selectionValue = GUILayout.Toolbar(selectionValue, stringArr);

    //    GUILayout.Space(15);

    //    // selection grid
    //    selectionValue = GUILayout.SelectionGrid(selectionValue, stringArr, 2);

    //    // box (e.g. texture)
    //    // https://github.com/halak/unity-editor-icons
    //    GUILayout.Box(EditorGUIUtility.IconContent("Animation.Record"));
    //    GUILayout.Box(EditorGUIUtility.IconContent("animationvisibilitytoggleon"));
    //    GUILayout.Box(EditorGUIUtility.IconContent("animationvisibilitytoggleon@2x"));

    //    #endregion

    //}

    #endregion

    #region GUI 그리기4 (Layout system)

    //Vector3 scrollPos;

    //private void OnGUI()
    //{
    //    #region ===:: Layout을 좀 더 정밀하게 다루어보자 ::===
    //    {
    //        #region ===:: Vertical ::===

    //        // Begin으로 시작하면 End로 끝나야함 (한 쌍으로 이루어져야한다.)
    //        EditorGUILayout.BeginVertical(); // 세로로 GUI를 생성
    //        {
    //            for (int i = 0; i < 3; i++)
    //            {
    //                EditorGUILayout.LabelField("Label_01!!!");
    //            }
    //        }
    //        EditorGUILayout.EndVertical();

    //        EditorGUILayout.Space(15);

    //        EditorGUILayout.BeginVertical();
    //        {
    //            for (int i = 0; i < 3; i++)
    //            {
    //                EditorGUILayout.LabelField("Label_02!!!");
    //            }
    //        }
    //        EditorGUILayout.EndVertical();

    //        #endregion

    //        EditorGUILayout.Space(15);

    //        scrollPos = EditorGUILayout.BeginScrollView(scrollPos);
    //        {
    //            #region ===:: Horizontal ::===


    //            EditorGUILayout.BeginHorizontal(); // 가로로 GUI 생성
    //            {
    //                for (int i = 0; i < 10; i++)
    //                {
    //                    EditorGUILayout.LabelField("LabelField_01!!!");
    //                }
    //            }
    //            EditorGUILayout.EndHorizontal();

    //            EditorGUILayout.Space(15);

    //            EditorGUILayout.BeginHorizontal();
    //            {
    //                for (int i = 0; i < 10; i++)
    //                {
    //                    EditorGUILayout.LabelField("LabelField_02!!!");
    //                }
    //            }
    //            EditorGUILayout.EndHorizontal();

    //            #endregion
    //        }
    //        EditorGUILayout.EndScrollView();

    //        EditorGUILayout.Space(15);

    //        #region ===:: Vertical & Horizontal ::===

    //        for (int i = 0; i < 5; i++)
    //        {
    //            EditorGUILayout.BeginVertical();
    //            {
    //                EditorGUILayout.LabelField($"Title : {i}");

    //                var backUp01 = EditorGUIUtility.fieldWidth;
    //                var backUp02 = EditorGUIUtility.labelWidth;

    //                EditorGUIUtility.fieldWidth = 50; // 입력받을 필드의 크기
    //                EditorGUIUtility.labelWidth = 50; // 하나의 라벨이 차지하는 크기

    //                EditorGUILayout.BeginHorizontal();
    //                {
    //                    for (int j = 0; j < 3; j++)
    //                    {
    //                        EditorGUILayout.TextField(j.ToString(), "put data here");

    //                        // 마지막 요소인지 아닌지 확인
    //                        bool isLastData = j == 2;
    //                        if (isLastData == false)
    //                        {
    //                            EditorGUILayout.Space(6);
    //                        }
    //                    }
    //                }
    //                EditorGUILayout.EndHorizontal();

    //                // 전역적으로 사용되는 값들이기 때문에 의도치 않게 다른곳에서도 적용이 될 수 있기 때문...
    //                EditorGUIUtility.fieldWidth = backUp01;
    //                EditorGUIUtility.labelWidth = backUp02;
    //            }
    //            EditorGUILayout.EndVertical();

    //            EditorGUILayout.Space(20);

    //            if (i < 4)
    //            {
    //                EditorGUILayout.LabelField("", GUI.skin.horizontalScrollbar);
    //            }
    //        }

    //        #endregion
    //    }
    //    #endregion
    //}

    #endregion



    #region GUI 그리기5 (영역 나누기)

    //Vector3 scrollPos;

    //private void OnGUI()
    //{
    //    #region ===:: Area ::===

    //    // EditorWindow의 기준점 (0, 0)은 최측상단이다.
    //    var offset = new Vector2(20, 40);
    //    var rtArea = new Rect(offset.x, offset.y, position.width - offset.x * 2, 200);

    //    GUILayout.BeginArea(rtArea, GUI.skin.window);
    //    {
    //        #region ===:: Horizontal ::===

    //        scrollPos = EditorGUILayout.BeginScrollView(scrollPos);
    //        {
    //            EditorGUILayout.BeginHorizontal();
    //            {
    //                EditorGUILayout.LabelField("HGoHOHOH");
    //                EditorGUILayout.LabelField("HGoHOHOH");
    //                EditorGUILayout.LabelField("HGoHOHOH");
    //                EditorGUILayout.LabelField("HGoHOHOH");
    //            }
    //            EditorGUILayout.EndHorizontal();
    //        }
    //        EditorGUILayout.EndScrollView();

    //        #endregion

    //    }
    //    GUILayout.EndArea();

    //    #endregion
    //}

    #endregion



    #region GUI 그리기6 (다중 영역 나누기)

    //Vector3 scrollPos_01;
    //Vector3 scrollPos_02;

    //private void OnGUI()
    //{
    //    #region ===:: Area ::===
    //    var offset = new Vector2(20, 40);
    //    var rtArea = new Rect(offset.x, offset.y, position.width - offset.x * 2, 200);

    //    GUILayout.BeginArea(rtArea, GUI.skin.window);
    //    {
    //        #region ===:: Multiple Area ::===

    //        // left
    //        var rtSub = rtArea;
    //        rtSub.Set(0, 0, rtSub.width * 0.5f, rtSub.height);

    //        GUILayout.BeginArea(rtSub, "Sub_01", GUI.skin.window);
    //        {
    //            scrollPos_01 = EditorGUILayout.BeginScrollView(scrollPos_01);
    //            {
    //                EditorGUILayout.BeginVertical();
    //                {
    //                    for (int i = 0; i < 30; i++)
    //                    {
    //                        EditorGUILayout.LabelField("HoleHoly!!!");
    //                    }
    //                }
    //                EditorGUILayout.EndVertical();
    //            }
    //            EditorGUILayout.EndScrollView();
    //        }
    //        GUILayout.EndArea();


    //        // right
    //        rtSub.x += rtSub.width;

    //        GUILayout.BeginArea(rtSub, "Sub_02", GUI.skin.window);
    //        {
    //            scrollPos_02 = EditorGUILayout.BeginScrollView(scrollPos_02);
    //            {
    //                EditorGUILayout.BeginHorizontal();
    //                {
    //                    for (int i = 0; i < 30; i++)
    //                    {
    //                        EditorGUILayout.LabelField("HoleHoly!!!");
    //                    }
    //                }
    //                EditorGUILayout.EndHorizontal();
    //            }
    //            EditorGUILayout.EndScrollView();
    //        }
    //        GUILayout.EndArea();

    //        #endregion
    //    }
    //    GUILayout.EndArea();
    //    #endregion
    //}

    #endregion



    #region GUI 그리기7 (다중 영역 나누기)

    Vector3 scrollPos_01;
    Vector3 scrollPos_02;

    private void OnGUI()
    {
        #region ===:: Scope ::===
        {
            #region ===:: Horizontal ::===

            //using (var scope = new EditorGUILayout.HorizontalScope())
            //{
            //    // 여기에 생성된 크기가 결국 버튼의 크기가 된다.
            //    if (GUI.Button(scope.rect, GUIContent.none))
            //    {
            //        Debug.Log("clicked");
            //    }

            //    for (int i = 0; i < 5; i++)
            //    {
            //        GUILayout.Label("Label!!!");
            //        GUILayout.Box(EditorGUIUtility.FindTexture("BuildSettings.Editor"));
            //    }
            //}

            #endregion

            #region ===:: Vertical ::===

            using (var scope = new EditorGUILayout.VerticalScope(GUILayout.Width(100)))
            {
                if (GUI.Button(scope.rect, GUIContent.none))
                {
                    Debug.Log("clicked");
                }

                for (int i = 0; i < 5; i++)
                {
                    GUILayout.Label("Label!!!");
                    GUILayout.Box(EditorGUIUtility.FindTexture("BuildSettings.Editor"));
                }
            }

            #endregion
        }
        #endregion
    }

    #endregion
}
