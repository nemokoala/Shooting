using kuma;
using MineSweeperFinal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test;

namespace Shooting
{ 
    public partial class MainForm : Form
    {
        private int shootingStage = 0;
        private int shootingScore = 0;
        private int jellyScore = 0;
        private int reactionScore = 0;
        private int ytmtScore = 0;
        private int moleScore = 0;
        public static Boolean ShowMainForm = true;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void Refresh()
        {
            IniFile ini = new IniFile();
            try {ini.Load("GameData.ini");}catch{}

            shootingScore = ini["슈팅"]["점수"].ToInt();
            shootingStage = ini["슈팅"]["스테이지"].ToInt();
            jellyScore = ini["젤리"]["점수"].ToInt();
            reactionScore = ini["반응속도"]["점수"].ToInt();
            ytmtScore = ini["니편내편"]["점수"].ToInt();
            moleScore = ini["두더지"]["점수"].ToInt();
            ShootingBtn.Text = "슈팅게임\r최대 점수: " + shootingScore + "\r최대 스테이지: " + shootingStage;
            ReactionBtn.Text = "반응속도 게임\r최고 반응속도: " + reactionScore + "ms";
            DinoBtn.Text = "공룡게임\r최대 점수: " + jellyScore;
            YTMTBtn.Text = "니편내편\r최대 점수: " + ytmtScore;
            MoleBtn.Text = "두더지 찾기\r최대 점수: " + moleScore;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Refresh();
        }
        private void ShootingBtn_Click(object sender, EventArgs e)
        {
            ShootingForm form1 = new ShootingForm(this);
            form1.Show();
            this.Hide();
        }
        private void ReactionBtn_Click(object sender, EventArgs e)
        {
            ReactionForm reactionForm = new ReactionForm(this);
            reactionForm.Show();
            this.Hide();
        }
        private void DinoBtn_Click(object sender, EventArgs e)
        {
            JellyForm jellyForm = new JellyForm(this);
            jellyForm.Show();
            this.Hide();
        }
        private void MineBtn_Click(object sender, EventArgs e)
        {
            GameInit gameInit = new GameInit();
            gameInit.Show();
            this.Hide();
        }

        private void YTMTBtn_Click(object sender, EventArgs e)
        {
            YTMT yTMT = new YTMT();
            yTMT.Show();
            this.Hide();
        }

        private void MainForm_MouseEnter(object sender, EventArgs e)
        {
            Refresh();
        }

        private void MoleBtn_Click(object sender, EventArgs e)
        {
            MoleForm moleForm = new MoleForm();
            moleForm.Show();
            this.Hide();
        }

        private void ShootingBtn_MouseHover(object sender, EventArgs e)
        {
            UITEXT.Text = "<슈팅 게임>\n쏟아져 나오는 적들을 제거하면서 오래동안 살아남으세요!" +
                "\n\n<조작법>\n키보드 방향키 ← : 왼쪽 이동\n키보드 방향키 → : 오른쪽 이동" +
                "\n\n<게임 설명>\n플레이어를 좌우로 움직여서 적들을 피하거나 총알로 적을 죽이세요.\n" +
                "점수는 적을 처치하면 얻을 수 있습니다. 이때 적을 처치하면 일정확률로 아이템이 드랍됩니다.\n" +
                "아이템을 꾸준히 먹어서 후반에도 잘 버텨보세요.";
            UITEXT.BackColor = Color.FromArgb(197, 208, 226);
        }

        private void MoleBtn_MouseHover(object sender, EventArgs e)
        {
            UITEXT.Text = "<두더지 게임>\n가장 많이 고개를 내민 두더지를 찾아주세요!" +
                "\n\n<조작법>\n플레이어를 움직여 두더지를 선택\n" +
                "키보드 방향키 ← : 왼쪽 이동\n키보드 방향키 → : 오른쪽 이동" +
                "\n\n<게임 설명>\n 라운드가 시작되면 두더지가 랜덤으로 고개를 내밉니다.\n" +
                "가장 고개를 많이 내민 두더지를 기억해 플레이어를 이동시켜 두더지를 찾아내면 됩니다.";
            UITEXT.BackColor = Color.FromArgb(209, 219, 199);
        }

        private void ReactionBtn_MouseHover(object sender, EventArgs e)
        {
            UITEXT.Text = "<반응속도 테스트 게임>\n화면색이 바뀌면 빠르게 클릭을 하여 반응속도를 테스트 해보세요!" +
                "\n\n<게임 방법>\n화면이 회색에서 하늘색으로 바뀌면 빠르게 클릭하세요.\n미리 클릭하면 무효입니다.\n" +
                "반응속도 수치가 낮을수록 좋은겁니다. (평균 200ms)";
            UITEXT.BackColor = Color.FromArgb(255, 203, 229);
        }

        private void MineBtn_MouseHover(object sender, EventArgs e)
        {
            UITEXT.Text = "<지뢰찾기 게임>\n지뢰가 없는 칸을 모두 클릭하면 승리합니다!" +
                "\n\n<게임 방법>\n지뢰가 없는 칸을 모두 클릭하면 승리.\n클릭한 칸을 중심으로 한 3*3 영역에 지뢰의 수가 나타남\n" +
                "우클릭을 통해 지뢰 마킹 가능";
            UITEXT.BackColor = Color.FromArgb(205, 205, 205);
        }

        private void DinoBtn_MouseHover(object sender, EventArgs e)
        {
            UITEXT.Text = "<공룡 게임>\n뛰어오는 공룡을 피하세요!" +
                "\n\n<조작법>\n" +
                "키보드 방향키 ↑ : 점프\n키보드 방향키 ↓ : 숙이기" +
                "\n\n<게임 방법>\n화면 우측에서 나오는 공룡을 점프나 숙이기로 피하세요.\n" +
                "시간이 지날수록 공룡의 속도가 빨라집니다.";
            UITEXT.BackColor = Color.FromArgb(215, 205, 231);
        }

        private void YTMTBtn_MouseHover(object sender, EventArgs e)
        {
            UITEXT.Text = "<니편내편 게임>\n알맞은 방향으로 공룡을 보내세요!" +
                "\n\n<조작법>\n" +
                "키보드 방향키 ← : 왼쪽 이동\n키보드 방향키 → : 오른쪽 이동" +
                "\n\n<게임 방법>\n현재 공룡을 왼쪽 또는 오른쪽으로 보내주세요.";
            UITEXT.BackColor = Color.FromArgb(255, 231, 208);
        }
    }
}
