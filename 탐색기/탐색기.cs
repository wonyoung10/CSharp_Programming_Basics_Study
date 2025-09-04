////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///////////     작성날짜 : 2024_12_16
///////////     작 성 자 : 정원영
///////////     내    용 : 파일 탐색기
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection.PortableExecutable;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 탐색기
{
    public partial class 탐색기 : Form
    {
        // 리스트 뷰 에 띄울 주소 값 가지고 있는 변수
        public DirectoryInfo dirInfo;
        public DirectoryInfo[] dirSubInfo;
        public int dirCount = 0;

        // 트리뷰 최고 부모 노드
        TreeNode rootNode = new TreeNode();
        // main 함수
        public 탐색기()
        {
            InitializeComponent();
            this.Text = "탐색기";
            string initialPath = "C:\\"; // 원하는 루트 디렉터리 경로로 변경
            dirInfo = new DirectoryInfo(initialPath); // initialPath에 저장된 경로 객체 생성
            label1.Text = initialPath.ToString();
            if (dirInfo.Exists) // 실제로 존재하는 디렉터리 경로 인지 확인 용
            {
               

                
                treeView1.Nodes.Clear();
                // roorNode 기초 설정;
                rootNode.Text = "내 pc"; 
                rootNode.Tag = dirInfo;

                // treeview 저장 및 list view 출력
                LoadDirectory_ListView();
                LoadDirectory_TreeView(rootNode, initialPath);
                // treeview 출력
                treeView1.Nodes.Add(rootNode);

            }
        }
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///////////     
///////////    트리뷰 저장을 위한 재귀 
///////////     
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void LoadDirectory_TreeView(TreeNode ParentNode, string path)
        {
            try
            {
                DirectoryInfo tree_dirInfo = new DirectoryInfo(path);
                DirectoryInfo[] tree_dirSubInfo = tree_dirInfo.GetDirectories(); // 하위 디렉터리 가져오기
                int tree_dirCount = tree_dirSubInfo.Length;

                if (!tree_dirInfo.Exists)
                    return;
                // 폴더 저장
                foreach (DirectoryInfo d in tree_dirSubInfo)
                {
                    TreeNode node = new TreeNode(d.Name);
                    node.ImageIndex = 0;
                    node.SelectedImageIndex = 0;
                    node.Tag = d;
                    ParentNode.Nodes.Add(node);

                    LoadDirectory_TreeView(node, d.FullName);
                }
                // 파일 저장
                FileInfo[] files = tree_dirInfo.GetFiles();
                foreach (FileInfo f in files)
                {

                    TreeNode node = new TreeNode(f.Name.ToString());
                    node.ImageIndex = 1;
                    node.SelectedImageIndex = 1;
                    node.Tag = f.FullName;
                    ParentNode.Nodes.Add(node);


                }


            }
            catch (DirectoryNotFoundException ex) // 지정된 경로가 존재 하지 않을 때 예외 처리
            { 
            }
            catch (UnauthorizedAccessException ex) // 접근 권한이 없을 때 예외 처리
            { 
            }
        }

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///////////     
///////////    listView 출력
///////////     
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void LoadDirectory_ListView()
        {
            dirSubInfo = dirInfo.GetDirectories();
            dirCount = dirSubInfo.Length + 1;

            listView.Items.Clear();
            // .. 생성
            ListViewItem item = new ListViewItem("..", 0);
            item.SubItems.Add("");
            item.SubItems.Add("");
            item.SubItems.Add("");
            listView.Items.Add(item);
            // list view 에 폴더 추가
            foreach (DirectoryInfo d in dirSubInfo)
            {
                item = new ListViewItem(d.Name.ToString(), 0);
                item.SubItems.Add(d.Attributes.ToString());
                item.SubItems.Add("");
                item.SubItems.Add(d.CreationTime.ToString());
                listView.Items.Add(item);
            }
            // list view 에 파일 추가
            FileInfo[] files = dirInfo.GetFiles();
            foreach (FileInfo f in files)
            {
                item = new ListViewItem(f.Name.ToString(), 1);
                item.SubItems.Add(f.Attributes.ToString());
                item.SubItems.Add(f.Length.ToString());
                item.SubItems.Add(f.CreationTime.ToString());
                listView.Items.Add(item);
            }
        }
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///////////     
///////////    파일 버튼 클릭 후 가져오기
///////////     
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void ToolStripOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            dirInfo = new DirectoryInfo(openFileDialog.FileName); // 선택한 파일의 경로 가져오기


            dirInfo = dirInfo.Parent; // 선택한 파일의 부모 디렉터리 가져오기


            label1.Text = dirInfo.ToString();

            dirSubInfo = dirInfo.GetDirectories(); // 현재 디렉터리의 하위 디렉터리 목록 가져오기
            dirCount = dirSubInfo.Length + 1;
            // .. 생성
            listView.Items.Clear();
            ListViewItem item = new ListViewItem("..", 0);
            item.SubItems.Add("");
            item.SubItems.Add("");
            item.SubItems.Add("");
            listView.Items.Add(item);
            // list view 에 폴더 추가
            foreach (DirectoryInfo d in dirSubInfo)
            {
                item = new ListViewItem(d.Name.ToString(), 0);
                item.SubItems.Add(d.Attributes.ToString());
                item.SubItems.Add("");
                item.SubItems.Add(d.CreationTime.ToString());
                listView.Items.Add(item);
            }
            // list view 에 파일 추가
            FileInfo[] files = dirInfo.GetFiles();
            foreach (FileInfo f in files)
            {
                item = new ListViewItem(f.Name.ToString(), 1);
                item.SubItems.Add(f.Attributes.ToString());
                item.SubItems.Add(f.Length.ToString());
                item.SubItems.Add(f.CreationTime.ToString());
                listView.Items.Add(item);
            }

        }
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///////////////////////////
///////////////////////////  listView 클릭 했을 때 판별 및 
///////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
         
        private void listView_Click(object sender, EventArgs e)
        {
            int index = listView.FocusedItem.Index;

            // index 값 확인
            if (index >= dirCount)
            {
                MessageBox.Show("파일을 선택했습니다.");
                return;
            }

            if (index != 0)
            {
                dirInfo = dirSubInfo[index - 1];
            }
            else
            {
                if (dirInfo.Parent == null)
                {
                    MessageBox.Show("루트 디렉터리 입니다.");
                    return;
                }
                dirInfo = dirInfo.Parent;
            }

            Find_TreeVIew_Tag_Start(rootNode, dirInfo);



            // list view 출력 
            label1.Text = dirInfo.ToString();
            listView.Items.Clear();
            // .. 추가
            ListViewItem item = new ListViewItem("..", 0);
            item.SubItems.Add("");
            item.SubItems.Add("");
            item.SubItems.Add("");
            listView.Items.Add(item);

            dirSubInfo = dirInfo.GetDirectories();
            dirCount = dirSubInfo.Length + 1;
            // list view 에 폴더 추가
            foreach (DirectoryInfo d in dirSubInfo)
            {
                item = new ListViewItem(d.Name.ToString(), 0);
                item.SubItems.Add(d.Attributes.ToString());
                item.SubItems.Add("");
                item.SubItems.Add(d.CreationTime.ToString());
                listView.Items.Add(item);
            }
            // list view 에 파일 추가
            FileInfo[] files = dirInfo.GetFiles();
            foreach (FileInfo f in files)
            {
                item = new ListViewItem(f.Name.ToString(), 1);
                item.SubItems.Add(f.Attributes.ToString());
                item.SubItems.Add(f.Length.ToString());
                item.SubItems.Add(f.CreationTime.ToString());
                listView.Items.Add(item);
            }

        }
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///////////////////////////
///////////////////////////  같은 선상의 부모 노드 탐사 및 자식 노드 탐사용 재귀 함수 호출
///////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void Find_TreeVIew_Tag_Start(TreeNode TV, object tag)
        {
            rootNode.Expand();
            foreach (TreeNode node in TV.Nodes)
            {

                if (node.Tag.ToString() == tag.ToString()) // 부모 노드 에 있는지 확인
                {
                    node.Expand();  // 노드를 확장
                    return; // 탐색 종료
                }
                else Find_TreeVIew_Tag(node, tag);
            }
        }
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///////////////////////////
///////////////////////////  treeview 확장을 위한 자식 노드 탐사 재귀 
///////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void Find_TreeVIew_Tag(TreeNode ParentNode, object tag)
        {
            // tag가 일치하는 할때 해당 tag 노드를 확장
            if (ParentNode.Tag.ToString() != null && ParentNode.Tag.ToString().Equals(tag.ToString()))
            {

                ParentNode.Expand();  // 노드를 확장
                return;
            }

            // 자식 노드 재귀 탐사
            foreach (TreeNode ChildNode in ParentNode.Nodes)
            {
                //Debug.WriteLine(ChildNode);
                Find_TreeVIew_Tag(ChildNode, tag);
            }
        }


////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///////////////////////////
///////////////////////////  tree view node 클릭시 list view node 출력 
///////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // 클릭한 노드 tag 가져오기
            TreeNode clicknode = e.Node;
            dirInfo = clicknode.Tag as DirectoryInfo;
            // 태그 확인
            if (dirInfo != null)
            {
                Find_TreeVIew_Tag_Start(rootNode, dirInfo);
                label1.Text = dirInfo.ToString();
                listView.Items.Clear();

                ListViewItem item = new ListViewItem("..", 0);
                item.SubItems.Add("");
                item.SubItems.Add("");
                item.SubItems.Add("");
                listView.Items.Add(item);

                dirSubInfo = dirInfo.GetDirectories();
                dirCount = dirSubInfo.Length + 1;
                // list view 에 폴더 추가
                foreach (DirectoryInfo d in dirSubInfo)
                {
                    item = new ListViewItem(d.Name.ToString(), 0);
                    item.SubItems.Add(d.Attributes.ToString());
                    item.SubItems.Add("");
                    item.SubItems.Add(d.CreationTime.ToString());
                    listView.Items.Add(item);
                }
                // list view 에 파일 추가
                FileInfo[] files = dirInfo.GetFiles();
                foreach (FileInfo f in files)
                {
                    item = new ListViewItem(f.Name.ToString(), 1);
                    item.SubItems.Add(f.Attributes.ToString());
                    item.SubItems.Add(f.Length.ToString());
                    item.SubItems.Add(f.CreationTime.ToString());
                    listView.Items.Add(item);
                }
            }
        }
    }
}