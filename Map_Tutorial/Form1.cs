using AxMapWinGIS;
using MapWinGIS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Map_Tutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            axMap2.CurrentZoom = 6;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            axMap2.Projection = tkMapProjection.PROJECTION_GOOGLE_MERCATOR;
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            axMap2.TileProvider = MapWinGIS.tkTileProvider.OpenStreetMap;
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            axMap2.TileProvider = MapWinGIS.tkTileProvider.OpenHumanitarianMap;
        }

        private void axMap2_MouseDownEvent(object sender, AxMapWinGIS._DMapEvents_MouseDownEvent e)
        {

        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            axMap2.CursorMode = MapWinGIS.tkCursorMode.cmPan;
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            axMap2.CursorMode = MapWinGIS.tkCursorMode.cmZoomOut;
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            axMap2.CursorMode = MapWinGIS.tkCursorMode.cmMeasure;
        }
        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            axMap2.CursorMode = MapWinGIS.tkCursorMode.cmMeasure;
            axMap2.Measuring.MeasuringType = MapWinGIS.tkMeasuringType.MeasureArea;
        }
    }
}
