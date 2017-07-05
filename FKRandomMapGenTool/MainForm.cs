//------------------------------------------------------------
// Author:  FreeKnight
// Date:    20170705
// Desc:    
//------------------------------------------------------------
using System;
using System.Drawing;
using System.Windows.Forms;
using FKRandomMapGenLib;
//------------------------------------------------------------
namespace FKRandomMapGenTool
{
    public partial class MainForm : Form
    {
        #region 绘制变量

        private Graphics g;
        private bool drawBiomes         = true;
        private bool drawRivers         = true;
        private bool drawSites          = false;
        private bool drawCorners        = false;
        private bool drawDelaunay       = false;
        private bool lighting           = true;
        private bool noisyEdges         = true;
        private bool smoothBlending     = true;

        #endregion 绘制变量

        #region Voronoi逻辑变量

        private bool    moreRandom = true;
        private int     numSites = 6000;
        private int     numLloyd = 2;
        private int     bounds = 600;
        private int     seed = 0;

        private VoronoiGraph voronoiGraph;
        private Random seedGen;
        private Bitmap finalImg;

        #endregion Voronoi逻辑变量

        public MainForm()
        {
            InitializeComponent();

            g = this.MapPanel.CreateGraphics();
            seedGen = new Random();
        }

        public static VoronoiGraph CreateVoronoiGraph(int bounds, int numSites, int numLloyd, int seed, bool moreRandom)
        {
            Random r = new Random(seed);
            Voronoi v = new Voronoi(numSites, bounds, bounds, r);
            VoronoiGraphImplemention graph = new VoronoiGraphImplemention(v, numLloyd, r, moreRandom);
            return graph;
        }

        /// <summary>
        /// 创建地图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateButton_Click(object sender, EventArgs e)
        {
            { 
                // 记录图形选项
                if (nSitesBox.Text != "")
                {
                    try
                    {
                        numSites = int.Parse(nSitesBox.Text);
                    }
                    catch (Exception)
                    {
                        numSites = 6000;
                    }
                }
                else
                {
                    numSites = 6000;
                }

                if (nLloydBox.Text != "")
                {
                    try
                    {
                        numLloyd = int.Parse(nLloydBox.Text);
                    }
                    catch (Exception)
                    {
                        numLloyd = 2;
                    }
                }
                else
                {
                    numLloyd = 2;
                }

                seed = seedGen.Next();
                seedBox.Text = seed + "";

                moreRandom = RHeightCheck.Checked;
            }

            // 生成图形对象
            voronoiGraph = CreateVoronoiGraph(bounds, numSites, numLloyd, seed, moreRandom);

            // 渲染图形
            Bitmap img = voronoiGraph.CreateMap(g, drawBiomes, drawRivers, drawSites, 
                drawCorners, drawDelaunay, noisyEdges, smoothBlending, lighting);
            Bitmap noiseImg = CreateNoiseMap();

            finalImg = new Bitmap(bounds, bounds);
            Graphics tmpGraphics = Graphics.FromImage(finalImg);

            tmpGraphics.DrawImage(img, new PointF(0, 0));
            tmpGraphics.DrawImage(noiseImg, new PointF(0, 0));

            MapImageBox.Image = finalImg;
            MapPanel.Refresh();
        }

        /// <summary>
        /// 生成随机种子按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenRandomSeedBtn_Click(object sender, EventArgs e)
        {
            seed = seedGen.Next();
            seedBox.Text = seed + "";
        }

        /// <summary>
        /// 截屏按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (finalImg != null)
                finalImg.Save("FKMap_" + seed + ".png", System.Drawing.Imaging.ImageFormat.Png);
        }

        /// <summary>
        /// 创建噪音图
        /// </summary>
        /// <param name="tG"></param>
        private Bitmap CreateNoiseMap()
        {
            SimplexNoise s = new SimplexNoise(16, 0.45, seed);
            Bitmap noiseImg = s.GenerateGreyScale(bounds, bounds);
            return noiseImg;
        }
    }
}
